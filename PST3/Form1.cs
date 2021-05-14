using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PST3 {
    /// <summary>
    ///  Runs pig dice game
    /// </summary>
    /// <author>Ashley De Xuan Poon</author>
    /// <student_id>n9629238</student_id>
    public partial class Form1 : Form {

        //boolean var to check if a single one is rolled
        static bool singleOne = false;
        
        //variables to store points
        static int userScore;
        static int currentScore;
        static int cpuScore;

        //constant variables
        const int winMinimum = 100;
        const int minCpuScoreToEnd = 20;
        const int doubleOnesPoints = 25;

        //create dices
        Die die1 = new Die();
        Die die2 = new Die();

        //create a random number generator
        Random numberGenerator = new Random();

        public Form1() {
            InitializeComponent();

            //display a pair of dices upon startup
            dieImage1.BackgroundImage = Images.GetDieImage(1);
            dieImage2.BackgroundImage = Images.GetDieImage(1);

            //inform that user plays first
            UserTurn();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            //exit the game when user selects exit
            Close();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e) {
            Restart();

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            //show a message box consisting of name of author of the program
            MessageBox.Show("Author: Ashley De Xuan Poon", "About");

        }

        private void rollButton_Click(object sender, EventArgs e) {
            UserRoll();
        }

        private void endTurnButton_Click(object sender, EventArgs e) {
            CpuRoll();
        }

        /// <summary>
        /// resets all scores and interface features as per the beginning of the game
        /// </summary>
        private void Restart() {
            //update the status label, enable roll button and disable end turn button
            UserTurn();
            endTurnButton.Enabled = false;
            rollButton.Enabled = true;

            //reset and refresh all score labels and variables to 0
            cpuTotalScoreLabel.Text = "0";
            cpuTotalScoreLabel.Refresh();
            cpuScore = 0;
            userTotalScoreLabel.Text = "0";
            userTotalScoreLabel.Refresh();
            userScore = 0;
            currentTurnScoreLabel.Text = "0";
            currentTurnScoreLabel.Refresh();
            currentScore = 0;
        }

        /// <summary>
        /// rolls both dices and adjusts the score according to its values
        /// </summary>
        private void UserRoll() {

            //update status and disable end turn button
            UserTurn();
            endTurnButton.Enabled = false;

            //initiate the roll animation
            RollAnimation();

            //roll dices and refresh images
            die1.Roll();
            die2.Roll();
            dieImage1.BackgroundImage = Images.GetDieImage(die1.FaceValue);
            dieImage2.BackgroundImage = Images.GetDieImage(die2.FaceValue);
            dieImage1.Refresh();
            dieImage2.Refresh();

            if (die1.FaceValue == 1 && die2.FaceValue != 1) { 
                //if die 1 has rolled a 1 
                //roll button is disabled
                rollButton.Enabled = false;

                //reset the current score and update status label
                currentScore = 0;
                currentTurnScoreLabel.Text = currentScore.ToString();
                UserRolledOne();

            } else if (die2.FaceValue == 1 && die1.FaceValue != 1) {
                //if die 2 has rolled a 1
                //roll button is disabled
                rollButton.Enabled = false;

                //reset the current score and update status label
                currentScore = 0;
                currentTurnScoreLabel.Text = currentScore.ToString();
                UserRolledOne();

            } else if (die1.FaceValue == 1 && die2.FaceValue == 1) {
                //if both dices are 1, add 25 to the current score
                currentScore += doubleOnesPoints;
                currentTurnScoreLabel.Text = currentScore.ToString();

            } else {
                //sum up roll score and update the current score label
                currentScore = currentScore + die1.FaceValue + die2.FaceValue;
                currentTurnScoreLabel.Text = currentScore.ToString();
            }

            //enable end turn button
            endTurnButton.Enabled = true;

            //if the total score adds up to 100, disable roll and end turn button
            //and update the status label
            if((userScore + currentScore) >= winMinimum) {
                rollButton.Enabled = false;
                endTurnButton.Enabled = false;
                turnStatusLabel.BackColor = Color.Green;
                turnStatusLabel.Text = "You won!";
                turnStatusLabel.Refresh();
            }
        }

        /// <summary>
        /// updates the user's score and starts the cpu's turn
        /// </summary>
        private void CpuRoll() {
            //tally up and update the user's score and reset and update the current score to 0
            //as a new turn has begun
            userScore += currentScore;
            userTotalScoreLabel.Text = userScore.ToString();
            userTotalScoreLabel.Refresh();
            currentScore = 0;
            currentTurnScoreLabel.Text = currentScore.ToString();
            currentTurnScoreLabel.Refresh();

            //update status label
            CpuTurn();

            //disable endturn and roll button
            endTurnButton.Enabled = false;
            rollButton.Enabled = false;

            //repeat sequence while it is not the user's turn, any one die
            //does not have a face value of one, current score < 20 and < 100
            do {
                //initiate the roll animation
                RollAnimation();

                //roll dices and refresh images
                die1.Roll();
                die2.Roll();
                dieImage1.BackgroundImage = Images.GetDieImage(die1.FaceValue);
                dieImage2.BackgroundImage = Images.GetDieImage(die2.FaceValue);
                dieImage1.Refresh();
                dieImage2.Refresh();

                if (die1.FaceValue == 1 && die2.FaceValue != 1) {
                    //if die1 rolls a 1, reset current score, update singleOne
                    //and status label
                    singleOne = true;
                    currentScore = 0;
                    CpuRolledOne();
                    
                    //wait for 1 second, updating turn status label and enabling
                    //the roll button
                    System.Threading.Thread.Sleep(1000);
                    UserTurn();
                    rollButton.Enabled = true;

                } else if (die2.FaceValue == 1 && die1.FaceValue != 1) {
                    //if die2 rolls a 1, reset current score, update singleOne
                    //and status label
                    singleOne = true;
                    currentScore = 0;
                    CpuRolledOne();

                    //wait for 1 second, updating turn status label and enabling
                    //the roll button
                    System.Threading.Thread.Sleep(1000);
                    UserTurn();
                    rollButton.Enabled = true;

                } else if (die1.FaceValue == 1 && die2.FaceValue == 1) {
                    //if both dices have a face value of one, add 25 to the current score,
                    //update current score and status label and enable roll button
                    currentScore += doubleOnesPoints;
                    currentTurnScoreLabel.Text = currentScore.ToString();
                    currentTurnScoreLabel.Refresh();
                    System.Threading.Thread.Sleep(1000);
                    UserTurn();
                    rollButton.Enabled = true;

                } else {
                    //sum up face values of both dices, update current score label
                    //and wait two seconds before rolling again
                    currentScore = currentScore + die1.FaceValue + die2.FaceValue;
                    currentTurnScoreLabel.Text = currentScore.ToString();
                    currentTurnScoreLabel.Refresh();
                    System.Threading.Thread.Sleep(2000);
                }
                
            } while (singleOne == false && currentScore < 20 && (cpuScore + currentScore) < 100);
            
            //update status label and enable roll button
            UserTurn();
            rollButton.Enabled = true;
 
            //reset bool variables for the next cpu turn
            singleOne = false;

            //tally up and update the cpu's score and reset and update the current score to 0
            //as a new turn has begun
            cpuScore += currentScore;
            cpuTotalScoreLabel.Text = cpuScore.ToString();
            cpuTotalScoreLabel.Refresh();
            currentScore = 0;
            currentTurnScoreLabel.Text = currentScore.ToString();
            currentTurnScoreLabel.Refresh();

            //if cpu score is >= 100, disable end turn button and update status label
            if (cpuScore >= winMinimum) {
                    rollButton.Enabled = false;
                    turnStatusLabel.BackColor = Color.IndianRed;
                    turnStatusLabel.Text = "I won!";
                    turnStatusLabel.Refresh();
            }
        }

        /// <summary>
        /// animates the dice roll prior to the final randomised value
        /// </summary>
        private void RollAnimation() {
            //initiate roll animation
            for (int i = 0; i < 7; i++) {

                //for each iteration, each die chooses a random number between 1-6,
                //refreshes and waits for a short amount of time
                int randomRollNum = numberGenerator.Next(1, 6 + 1);
                dieImage1.BackgroundImage = Images.GetDieImage(randomRollNum);
                dieImage2.BackgroundImage = Images.GetDieImage(randomRollNum);
                dieImage1.Refresh();
                dieImage2.Refresh();
                System.Threading.Thread.Sleep(75);
            }
        }

        /// <summary>
        /// changes the status label's colour and text when it is the users turn
        /// </summary>
        private void UserTurn() {
            turnStatusLabel.BackColor = Color.Green;
            turnStatusLabel.Text = "Your turn!";
            turnStatusLabel.Refresh();
        }

        /// <summary>
        /// changes the status label's colour and text when it is the cpus turn
        /// </summary>
        private void CpuTurn() {
            turnStatusLabel.BackColor = Color.IndianRed;
            turnStatusLabel.Text = "My turn!";
            turnStatusLabel.Refresh();
        }

        /// <summary>
        /// changes the status label's colour and text when cpu rolls a one
        /// </summary>
        private void CpuRolledOne() {
            turnStatusLabel.BackColor = Color.Yellow;
            turnStatusLabel.Text = "I rolled a one!";
            turnStatusLabel.Refresh();
        }

        /// <summary>
        /// changes the status label's colour and text when user rolls a one
        /// </summary>
        private void UserRolledOne() {
            turnStatusLabel.BackColor = Color.Yellow;
            turnStatusLabel.Text = "You rolled a one!";
            turnStatusLabel.Refresh();
        }
    }
}
