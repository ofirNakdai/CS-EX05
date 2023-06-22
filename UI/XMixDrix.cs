using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ex02.ConsoleUtils;
using Logics;

namespace UI
{
    public partial class XMixDrix : Form
    {
        private readonly SettingsDialog r_SettingsForm;
        private readonly BaseForm r_IntroForm;
        private GameManagement m_Game = new GameManagement();


        public XMixDrix()
        {
            InitializeComponent();
            r_IntroForm = new BaseForm();
            Application.Run(r_IntroForm);

            r_SettingsForm = new SettingsDialog();
            if (r_IntroForm.DialogResult == DialogResult.OK)
            {
                Application.Run(r_SettingsForm);
            }
            else
            {
                r_SettingsForm.DialogResult = DialogResult.None;
            }

            if (r_SettingsForm.DialogResult == DialogResult.OK)
            {
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                
                m_Game.SetBoardBySize(r_SettingsForm.BoardSize);
                m_Game.InitPlayers(r_SettingsForm.PlayerType);

                //runGame();
            }
            else
            {
                this.Close();
            }
        }

        /*private void runGame()
        {
            bool quitInput = false;

            do
            {
                m_Game.SetupNewRound();
                while (m_Game.CurrentState == eGameState.Running && !quitInput)
                {
                    printBoard(m_Game.Board);
                    quitInput = getMove(out int row, out int col);
                    if (!quitInput)
                    {
                        while (!m_Game.IsValidMove(row, col))
                        {
                            invalidMoveMassage();
                            quitInput = getMove(out row, out col);
                        }

                        m_Game.MakeMove(row, col);
                        m_Game.CheckCurrentState(row, col);
                    }
                }

                if (!quitInput)
                {
                    showStateAndScore();
                }

                quitInput = askForAnotherRound();
            }

            while (!quitInput);
        }*/

        private void XMixDrix_Load(object sender, EventArgs e)
        {
            // initiate board 
        }
    }
}
