using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CS_Sanmoku {
	public partial class Form1 : Form {
		private Cell[] cell;
		private int num_turn;
		public int NumTurn {
			get { return num_turn; }
			set { if(flag_win == false) num_turn = value; }
		}
		private bool flag_win;

		public Form1() {
			InitializeComponent();
			Reset();		

		}

		private void JugeWin() {
			if(cell[0].NumStatus == NumTurn % 2 && cell[1].NumStatus == NumTurn % 2 && cell[2].NumStatus == NumTurn % 2) {
				flag_win = true;
			}
			if(cell[3].NumStatus == NumTurn % 2 && cell[4].NumStatus == NumTurn % 2 && cell[5].NumStatus == NumTurn % 2) {
				flag_win = true;
			}
			if(cell[6].NumStatus == NumTurn % 2 && cell[7].NumStatus == NumTurn % 2 && cell[8].NumStatus == NumTurn % 2) {
				flag_win = true;
			}


			if(cell[0].NumStatus == NumTurn % 2 && cell[3].NumStatus == NumTurn % 2 && cell[6].NumStatus == NumTurn % 2) {
				flag_win = true;
			}
			if(cell[1].NumStatus == NumTurn % 2 && cell[4].NumStatus == NumTurn % 2 && cell[7].NumStatus == NumTurn % 2) {
				flag_win = true;
			}
			if(cell[2].NumStatus == NumTurn % 2 && cell[5].NumStatus == NumTurn % 2 && cell[8].NumStatus == NumTurn % 2) {
				flag_win = true;
			}


			if(cell[0].NumStatus == NumTurn % 2 && cell[4].NumStatus == NumTurn % 2 && cell[8].NumStatus == NumTurn % 2) {
				flag_win = true;
			}
			if(cell[2].NumStatus == NumTurn % 2 && cell[4].NumStatus == NumTurn % 2 && cell[6].NumStatus == NumTurn % 2) {
				flag_win = true;
			}
		}

		private void Reset() {
			cell = new Cell[9];
			for(int i = 0; i < cell.Length; i++) {
				cell[i] = new Cell();
			}

			flag_win = false;
			NumTurn = 0;
			LabelRefresh();
			ButtonRefresh();
		}

		private void ButtonRefresh() {
			button1.Text = (cell[0].NumStatus == 0) ? "●" : (cell[0].NumStatus == 1) ? "○" : "-";
			button2.Text = (cell[1].NumStatus == 0) ? "●" : (cell[1].NumStatus == 1) ? "○" : "-";
			button3.Text = (cell[2].NumStatus == 0) ? "●" : (cell[2].NumStatus == 1) ? "○" : "-";
			button4.Text = (cell[3].NumStatus == 0) ? "●" : (cell[3].NumStatus == 1) ? "○" : "-";
			button5.Text = (cell[4].NumStatus == 0) ? "●" : (cell[4].NumStatus == 1) ? "○" : "-";
			button6.Text = (cell[5].NumStatus == 0) ? "●" : (cell[5].NumStatus == 1) ? "○" : "-";
			button7.Text = (cell[6].NumStatus == 0) ? "●" : (cell[6].NumStatus == 1) ? "○" : "-";
			button8.Text = (cell[7].NumStatus == 0) ? "●" : (cell[7].NumStatus == 1) ? "○" : "-";
			button9.Text = (cell[8].NumStatus == 0) ? "●" : (cell[8].NumStatus == 1) ? "○" : "-";
		}

		private void LabelRefresh() {
			if(NumTurn != 9) {
				label1.Text = "Turn : " + (NumTurn + 1);
				label2.Text = (NumTurn % 2 == 0) ? "Black" + ((flag_win == true) ? " Win!" : "") : "White" + ((flag_win == true) ? " Win!" : "");
			} else {
				label1.Text = "";
				label2.Text = "Draw!";
			}
		}

		private void SetCellStatus(int num) {
			if(cell[num].NumStatus == 2 && flag_win == false) {
				cell[num].NumStatus = NumTurn % 2;
				JugeWin();
				NumTurn++;
			}
			LabelRefresh();
			ButtonRefresh();
		}

		private void button1_Click(object sender, EventArgs e) {
			SetCellStatus(0);
		}

		private void button2_Click(object sender, EventArgs e) {
			SetCellStatus(1);
		}

		private void button3_Click(object sender, EventArgs e) {
			SetCellStatus(2);
		}

		private void button4_Click(object sender, EventArgs e) {
			SetCellStatus(3);
		}

		private void button5_Click(object sender, EventArgs e) {
			SetCellStatus(4);
		}

		private void button6_Click(object sender, EventArgs e) {
			SetCellStatus(5);
		}

		private void button7_Click(object sender, EventArgs e) {
			SetCellStatus(6);
		}

		private void button8_Click(object sender, EventArgs e) {
			SetCellStatus(7);
		}

		private void button9_Click(object sender, EventArgs e) {
			SetCellStatus(8);
		}

		private void button10_Click(object sender, EventArgs e) {
			Reset();
		}

	}
}
