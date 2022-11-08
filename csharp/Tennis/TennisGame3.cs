namespace Tennis
{
    public class TennisGame3 : ITennisGame
    {
        private int player2Score;
        private int player1Score;
        private string p1N;
        private string p2N;

        public TennisGame3(string player1Name, string player2Name)
        {
            this.p1N = player1Name;
            this.p2N = player2Name;
        }

        public string GetScore()
        {
            string s;
            if ((player1Score < 4 && player2Score < 4) && (player1Score + player2Score < 6))
            {
                string[] p = { "Love", "Fifteen", "Thirty", "Forty" };
                s = p[player1Score];
                return (player1Score == player2Score) ? s + "-All" : s + "-" + p[player2Score];
            }
            else
            {
                if (player1Score == player2Score)
                    return "Deuce";
                s = player1Score > player2Score ? p1N : p2N;
                return ((player1Score - player2Score) * (player1Score - player2Score) == 1) ? "Advantage " + s : "Win for " + s;
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

