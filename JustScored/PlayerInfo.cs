namespace JustScored
{
    public class PlayerInfo
    {
        public string Name {get;}
        public float maxScore;
        public int GamesPlayed {get; set;} 
        public int GamesWon {get; set;} 

        public PlayerInfo ( string name)
        {
            Name = name;
            MaxScore = 0f;
            GamesPlayed = 0;
            GamesWon = 0;
        } 


        public float MaxScore
        {
            get {return maxScore; }
            set 
            {
                if (value > maxScore)
                {
                    maxScore = value;
                }
            }
        }

        public float RateOfSuccess
        {
            get 
            {
                if (GamesPlayed == 0)
                {
                    return 0f;
                }
                else
                {
                    float winRate = GamesWon/GamesPlayed;
                    return winRate;
                }
                    

            }
        }

        public void AddGame(bool win)
        {
            if (win == true)
            {
                GamesWon++;
            }
            
        }



        


        


    }
}