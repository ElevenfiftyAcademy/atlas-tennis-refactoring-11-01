namespace Tennis
{
    public class TennisGame3 : ITennisGame
    {
        private int player2Score;
        private int player1Score;
        private string player1Name;
        private string player2Name;

        public TennisGame3(string player1Name, string player2Name)
        {
            this.player1Name = player1Name;
            this.player2Name = player2Name;
        }

        public string GetScore()
        {
            string score;
            var isNotATieOrWin = (player1Score < 4 && player2Score < 4);

            if (isNotATieOrWin && (player1Score + player2Score < 6))
            {
                string[] scoreNames = { "Love", "Fifteen", "Thirty", "Forty" };
                score = scoreNames[player1Score];
                return (player1Score == player2Score) ? score + "-All" : score + "-" + scoreNames[player2Score];
            }
            else
            {
                if (player1Score == player2Score)
                    return "Deuce";
                score = player1Score > player2Score ? player1Name : player2Name;
                return ((player1Score - player2Score) * (player1Score - player2Score) == 1) ? "Advantage " + score : "Win for " + score;
            }
        }

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
                this.player1Score += 1;
            else
                this.player2Score += 1;
        }

    }
}

