namespace SQL_practice.DbModels
{
    public class LevelObject
    {

        public int Index { get; set; }
        public string XY {  get; set; }
        public int State { get; set; }
        public int Correct {  get; set; }

        public LevelObject(int index, string xy, int state, int correct)
        {
            Index = index;
            XY = xy;
            State = state;
            Correct = correct;
            
        }

        public LevelObject()
        {
            
        }

    }
}
