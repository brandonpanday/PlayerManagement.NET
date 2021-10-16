using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace AssignmentOne

{

    public enum PlayerType
    {
        HockeyPlayer,
        BasketballPlayer,
        BaseballPlayer
    }

    abstract class Player
    {


        public PlayerType playertype;
        public int PlayerId;
        public string PlayerName;
        public string TeamName;
        public int GamesPlayed;

        public Player(PlayerType playertype, int PlayerId, string PlayerName, string TeamName, int GamesPlayed)
        {
            this.playertype = playertype;
            this.PlayerId = PlayerId;
            this.PlayerName = PlayerName;
            this.TeamName = TeamName;
            this.GamesPlayed = GamesPlayed;
        }

        public Player()
        {

        }

        public abstract int Points();


    }

    class HockeyPlayer : Player
    {
        public int Assists;
        public int Goals;

        public HockeyPlayer(PlayerType playertype, int PlayerId, string PlayerName, string TeamName, int GamesPlayed, int Assists, int Goals) : base(PlayerType.HockeyPlayer, PlayerId, PlayerName, TeamName, GamesPlayed)
        {
            this.Assists = Assists;
            this.Goals = Goals;
        }

        public HockeyPlayer()
        {

        }

        public override int Points()
        {
            int points = this.Assists + (2 * this.Goals);
            return points;

        }

        public override string ToString()
        {
            return String.Format("{0,18} {1,12} {2, 12} {3,12} {4,12} {5,12} {6,12} {7,12}",
                this.playertype, this.PlayerId, this.PlayerName, this.TeamName, this.GamesPlayed, this.Assists, this.Goals, this.Points());
        }
    }

    class BasketballPlayer : Player
    {
        public int FieldGoals;
        public int ThreePointers;

        public BasketballPlayer(PlayerType playertype, int PlayerId, string PlayerName, string TeamName, int GamesPlayed, int FieldGoals, int ThreePointers) : base(PlayerType.BasketballPlayer, PlayerId, PlayerName, TeamName, GamesPlayed)
        {
            this.FieldGoals = FieldGoals;
            this.ThreePointers = ThreePointers;
        }

        public BasketballPlayer()
        {

        }

        public override int Points()
        {
            int points = (this.FieldGoals - this.ThreePointers) + (2 * this.ThreePointers);
            return points;

        }

        public override string ToString()
        {
            return String.Format("{0,18} {1,12} {2, 12} {3,12} {4,12} {5,12} {6,12} {7,12}",
                   this.playertype, this.PlayerId, this.PlayerName, this.TeamName, this.GamesPlayed, this.FieldGoals, this.ThreePointers, this.Points());
        }

    }

    class BaseballPlayer : Player
    {
        public int Runs;
        public int HomeRuns;

        public BaseballPlayer(PlayerType playertype, int PlayerId, string PlayerName, string TeamName, int GamesPlayed, int Runs, int HomeRuns) : base(PlayerType.BaseballPlayer, PlayerId, PlayerName, TeamName, GamesPlayed)
        {
            this.Runs = Runs;
            this.HomeRuns = HomeRuns;
        }

        public override int Points()
        {
            int points = (this.Runs - this.HomeRuns) + (2 * this.HomeRuns);
            return points;
        }

        public override string ToString()
        {
            return String.Format("{0,18} {1,12} {2, 12} {3,12} {4,12} {5,12} {6,12} {7,12}",
                   this.playertype, this.PlayerId, this.PlayerName, this.TeamName, this.GamesPlayed, this.Runs, this.HomeRuns, this.Points());
        }

    }


}
