using System.Data.SqlClient;
using Dapper;
using TextObject = SQL_practice.DbModels.TextObject;
using SQL_practice.DbModels;
using Microsoft.AspNetCore.Http.HttpResults;

var builder = WebApplication.CreateBuilder(args);



var app = builder.Build();
app.UseHttpsRedirection();



//"Data Source=localhost;Initial Catalog=TextObjects;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False"
var connStr = builder.Configuration.GetConnectionString("TextObjectsdb");
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
app.MapPost("/levelobjects", async (LevelObject levelObject) =>
{
    var conn = new SqlConnection(connStr);
    var dbLevelObject = new
    {
        Index = levelObject.Index,
        XY = levelObject.XY,
        State = levelObject.State,
        Correct = levelObject.Correct,
    };
    var tableCreate = @"
USE [NonoGrams];
GO
CREATE TABLE [dbo].[LevelObject1_3] (
    [Index] int IDENTITY(1,1) PRIMARY KEY,
    XY nvarchar(255) NOT NULL,
    state int NOT NULL,
    correct bit NOT NULL
);";
    var sql = @"INSERT INTO LevelObject1_3 VALUES (@Index, @XY, @state, @correct)";
    var rowsAffected = await conn.ExecuteAsync(sql, dbLevelObject);
    return rowsAffected;
});

app.UseStaticFiles();
app.Run();


