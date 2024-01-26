using System.Data.SqlClient;
using Dapper;
using TextObject = SQL_practice.DbModels.TextObject;
using SQL_practice.DbModels;

var builder = WebApplication.CreateBuilder(args);



var app = builder.Build();
app.UseHttpsRedirection();

var connStr = "Data Source= (localdb)\\localhost;Initial Catalog=TextObjects;Integrated Security=True";
//"Data Source=localhost;Initial Catalog=TextObjects;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False"
app.MapGet("/textobjects", async () =>
{
    var conn = new SqlConnection(connStr);
    var sql = @"
        SELECT t.[Index], t.Text, c1.Color ForeColor, c2.Color BackColor
        FROM TextObject t
        JOIN Color c1 ON t.ForeColor = c1.Id
        JOIN Color c2 ON t.BackColor = c2.Id
    ";
    var textObjects = await conn.QueryAsync<TextObject>(sql);
    return textObjects;
});
app.MapPost("/textobjects", async (TextObject textObject) =>
{
    var conn = new SqlConnection(connStr);
    var dbTextObject = new
    {
        Index = textObject.Index,
        Text = textObject.Text,
        ForeColor = Enum.Parse<Color>(textObject.ForeColor),
        BackColor = Enum.Parse<Color>(textObject.BackColor)
    };
    var sql = @"INSERT INTO TextObject VALUES (@Index, @Text, @ForeColor, @BackColor)";
    var rowsAffected = await conn.ExecuteAsync(sql, dbTextObject);
    return rowsAffected;
});

app.UseStaticFiles();
app.Run();
