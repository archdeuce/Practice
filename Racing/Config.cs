using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing
{
    public static class Config
    {
        //
        // Window dimensions.
        //
        public const int ConsoleWidth = 45;
        public const int ConsoleHeight = 30;

        //
        // The coordinates of the curb.
        //
        public const int RoadSideX1 = 0;
        public const int RoadSideX2 = 22;

        public const int RoadSideY1 = 0;
        public const int RoadSideY2 = 30;

        //
        // The coordinates of the road.
        //
        public const int RoadX1 = RoadSideX1 + 1;
        public const int RoadX2 = RoadSideX2 - 1;

        public const int RoadY1 = RoadSideY1;
        public const int RoadY2 = RoadSideY2;

        //
        // Dimensions of the machine.
        //
        public const int CarWidth = 6;
        public const int CarHeight = 4;

        //
        // The coordinates of the player’s car.
        //
        public const int PlayerCarLeftPositionX = RoadSideX1 + 2;
        public const int PlayerCarLeftPositionY1 = RoadSideY2 - CarHeight;
        public const int PlayerCarLeftPositionY2 = RoadSideY2;

        public const int PlayerCarRightPositionX = RoadSideX2 - 8;
        public const int PlayerCarPositionY1 = RoadSideY2 - CarHeight;
        public const int PlayerCarPositionY2 = RoadSideY2;

        //
        // The coordinates of the enemy machine.
        //
        public const int RivalCarLeftPositionX = RoadSideX1 + 2;
        public const int RivalCarRightPositionX = RoadSideX2 - 8;

        public const int RivalCarStartPositionY1 = RoadSideY1 - Config.CarHeight - 1;
        public const int RivalCarStartPositionY2 = RoadSideY1 - 1;

        //
        // The coordinates of the info panel.
        //
        public const int InfoPanelPositionX1 = RoadSideX2 + 1;
        public const int InfoPanelPositionX2 = InfoPanelPositionX1 + 14;

        public const int InfoPanelPositionY1 = 0;
        public const int InfoPanelPositionY2 = 30;

        //
        // The coordinates of the lives.
        //
        public const string LivesTitle = "L I V E S";

        public const int LivesTitlePositionX = InfoPanelPositionX1 + 8;
        public const int LivesTitlePositionY = InfoPanelPositionY1 + 2;

        public const int LivesBarPositionX = InfoPanelPositionX1 + 8;
        public const int LivesBarPositionY = InfoPanelPositionY1 + 4;

        //
        // The coordinates of the score.
        //
        public const string ScoreTitle = "S C O R E";
        public const int MaxScore = 999999999;

        public const int ScoreTitlePositionX = InfoPanelPositionX1 + 8;
        public const int ScoreTitlePositionY = InfoPanelPositionY1 + 8;

        public const int ScorePositionX = InfoPanelPositionX1 + 8;
        public const int ScorePositionY = InfoPanelPositionY1 + 10;


        //
        // The coordinates of the level.
        //
        public const string SpeedTitle = "L E V E L";

        public const int SpeedTitlePositionX = InfoPanelPositionX1 + 8;
        public const int SpeedTitlePositionY = InfoPanelPositionY1 + 14;

        public const int SpeedMeterPositionX = InfoPanelPositionX1 + 8;
        public const int SpeedMeterPositionY = InfoPanelPositionY1 + 16;

        //
        // Game Over message position.
        //
        public const int GameOverX = 15;
        public const int GameOverY = 12;
        public const string GameOverText = "G A M E  O V E R";
        public const string GameOverTotalScoreText = "S C O R E: ";

        //
        // Pause message position.
        //
        public const string PаuseTextTitle1 = "Start / Pause:";
        public const int PаuseTextTitle1X = InfoPanelPositionX1 + 6;
        public const int PаuseTextTitle1Y = 26;

        public const string PаuseTextTitle2 = "<Space Button>";
        public const int PаuseTextTitle2X = InfoPanelPositionX1 + 6;
        public const int PаuseTextTitle2Y = 28;

        //
        // The number of lives.
        //
        public const int LivesNumber = 3;

        //
        // The distance between the cars of the enemy.
        //
        public const int RivalCarOffset = 18;
    }
}
