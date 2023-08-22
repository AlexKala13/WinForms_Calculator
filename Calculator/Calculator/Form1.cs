using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
	public partial class Calculator : Form
	{
		public static string currentNum = "0";
		public string prevNumb { get; set; }
		public string result { get; set; }
		public static char? lastOperation { get; set; }

		public Calculator()
		{
			InitializeComponent();
			this.KeyPreview = true;
			this.KeyPress += new KeyPressEventHandler(oneBtn_KeyPress);
			this.KeyPress += new KeyPressEventHandler(twoBtn_KeyPress);
			this.KeyPress += new KeyPressEventHandler(threeBtn_KeyPress);
			this.KeyPress += new KeyPressEventHandler(fourBtn_KeyPress);
			this.KeyPress += new KeyPressEventHandler(fiveBtn_KeyPress);
			this.KeyPress += new KeyPressEventHandler(sixBtn_KeyPress);
			this.KeyPress += new KeyPressEventHandler(sevenBtn_KeyPress);
			this.KeyPress += new KeyPressEventHandler(eightBtn_KeyPress);
			this.KeyPress += new KeyPressEventHandler(nineBtn_KeyPress);
			this.KeyPress += new KeyPressEventHandler(zeroBtn_KeyPress);
		}


		// calc //


		public static class lastOp
		{
			public static double Calc(string b, string a)
			{
				switch(lastOperation)
				{
					case '+':
						return Convert.ToDouble(b) + Convert.ToDouble(a);
					case '-':
						return Convert.ToDouble(b) - Convert.ToDouble(a);
					case 'X':
						return Convert.ToDouble(b) * Convert.ToDouble(a);
					case '/':
						return Convert.ToDouble(b) / Convert.ToDouble(a);
				}
				return 0;
			}
		}


		// numbers //


		public static string numberSelecting(string number)
		{
			if (currentNum == "0")
			{
				currentNum = number;
			}
			else
			{
				currentNum = string.Concat(currentNum, number);
			}
			return currentNum;
		}

		private void oneBtn_Click(object sender, EventArgs e)
		{
			currNum.Text = numberSelecting("1");
			currNum.Location = new Point(322 - ((currentNum.Count() - 1) * 19), 49);
		}

		private void twoBtn_Click(object sender, EventArgs e)
		{
			currNum.Text = numberSelecting("2");
			currNum.Location = new Point(322 - ((currentNum.Count() - 1) * 19), 49);
		}

		private void threeBtn_Click(object sender, EventArgs e)
		{
			currNum.Text = numberSelecting("3");
			currNum.Location = new Point(322 - ((currentNum.Count() - 1) * 19), 49);
		}

		private void fourBtn_Click(object sender, EventArgs e)
		{
			currNum.Text = numberSelecting("4");
			currNum.Location = new Point(322 - ((currentNum.Count() - 1) * 19), 49);
		}

		private void fiveBtn_Click(object sender, EventArgs e)
		{
			currNum.Text = numberSelecting("5");
			currNum.Location = new Point(322 - ((currentNum.Count() - 1) * 19), 49);
		}

		private void sixBtn_Click(object sender, EventArgs e)
		{
			currNum.Text = numberSelecting("6");
			currNum.Location = new Point(322 - ((currentNum.Count() - 1) * 19), 49);
		}

		private void sevenBtn_Click(object sender, EventArgs e)
		{
			currNum.Text = numberSelecting("7");
			currNum.Location = new Point(322 - ((currentNum.Count() - 1) * 19), 49);
		}

		private void eightBtn_Click(object sender, EventArgs e)
		{
			currNum.Text = numberSelecting("8");
			currNum.Location = new Point(322 - ((currentNum.Count() - 1) * 19), 49);
		}

		private void nineBtn_Click(object sender, EventArgs e)
		{
			currNum.Text = numberSelecting("9");
			currNum.Location = new Point(322 - ((currentNum.Count() - 1) * 19), 49);
		}

		private void zeroBtn_Click(object sender, EventArgs e)
		{
			currNum.Text = numberSelecting("0");
			currNum.Location = new Point(322 - ((currentNum.Count() - 1) * 19), 49);
		}

		private void oneBtn_KeyPress(object sender, KeyPressEventArgs e)
		{
			int number = Int32.Parse(e.KeyChar.ToString());
			if (number == 1)
			{
				currNum.Text = numberSelecting("1");
				currNum.Location = new Point(322 - ((currentNum.Count() - 1) * 19), 49);
			}
		}

		private void twoBtn_KeyPress(object sender, KeyPressEventArgs e)
		{
			int number = Int32.Parse(e.KeyChar.ToString());
			if (number == 2)
			{
				currNum.Text = numberSelecting("2");
				currNum.Location = new Point(322 - ((currentNum.Count() - 1) * 19), 49);
			}
		}

		private void threeBtn_KeyPress(object sender, KeyPressEventArgs e)
		{
			int number = Int32.Parse(e.KeyChar.ToString());
			if (number == 3)
			{
				currNum.Text = numberSelecting("3");
				currNum.Location = new Point(322 - ((currentNum.Count() - 1) * 19), 49);
			}
		}

		private void fourBtn_KeyPress(object sender, KeyPressEventArgs e)
		{
			int number = Int32.Parse(e.KeyChar.ToString());
			if (number == 4)
			{
				currNum.Text = numberSelecting("4");
				currNum.Location = new Point(322 - ((currentNum.Count() - 1) * 19), 49);
			}
		}

		private void fiveBtn_KeyPress(object sender, KeyPressEventArgs e)
		{
			int number = Int32.Parse(e.KeyChar.ToString());
			if (number == 5)
			{
				currNum.Text = numberSelecting("5");
				currNum.Location = new Point(322 - ((currentNum.Count() - 1) * 19), 49);
			}
		}

		private void sixBtn_KeyPress(object sender, KeyPressEventArgs e)
		{
			int number = Int32.Parse(e.KeyChar.ToString());
			if (number == 6)
			{
				currNum.Text = numberSelecting("6");
				currNum.Location = new Point(322 - ((currentNum.Count() - 1) * 19), 49);
			}
		}

		private void sevenBtn_KeyPress(object sender, KeyPressEventArgs e)
		{
			int number = Int32.Parse(e.KeyChar.ToString());
			if (number == 7)
			{
				currNum.Text = numberSelecting("7");
				currNum.Location = new Point(322 - ((currentNum.Count() - 1) * 19), 49);
			}
		}

		private void eightBtn_KeyPress(object sender, KeyPressEventArgs e)
		{
			int number = Int32.Parse(e.KeyChar.ToString());
			if (number == 8)
			{
				currNum.Text = numberSelecting("8");
				currNum.Location = new Point(322 - ((currentNum.Count() - 1) * 19), 49);
			}
		}

		private void nineBtn_KeyPress(object sender, KeyPressEventArgs e)
		{
			int number = Int32.Parse(e.KeyChar.ToString());
			if (number == 9)
			{
				currNum.Text = numberSelecting("9");
				currNum.Location = new Point(322 - ((currentNum.Count() - 1) * 19), 49);
			}
		}

		private void zeroBtn_KeyPress(object sender, KeyPressEventArgs e)
		{
			int number = Int32.Parse(e.KeyChar.ToString());
			if (number == 0)
			{
				currNum.Text = numberSelecting("0");
				currNum.Location = new Point(322 - ((currentNum.Count() - 1) * 19), 49);
			}
		}


		// operations //


		private void PlusBtn_Click(object sender, EventArgs e)
		{
			if (prevNumb == null)
			{
				prevNumb = currentNum;
				currentNum = null;
				currNum.Text = null;
				lastOperation = '+';
				prevNum.Location = new Point(322 - ((prevNumb.Count() - 1) * 12), 14);
				prevNum.Text = prevNumb;
				operatorLabel.Text = $"{lastOperation}";
			}
			else
			{
				result = Convert.ToString(lastOp.Calc(prevNumb, currentNum));
				prevNumb = result;
				currentNum = null;
				currNum.Text = null;
				lastOperation = '+';
				prevNum.Location = new Point(322 - ((prevNumb.Count() - 1) * 12), 14);
				prevNum.Text = prevNumb; 
				operatorLabel.Text = $"{lastOperation}";
			}
		}

		private void MinBtn_Click(object sender, EventArgs e)
		{
			if (prevNumb == null)
			{
				prevNumb = currentNum;
				currentNum = null;
				currNum.Text = null;
				lastOperation = '-';
				prevNum.Location = new Point(322 - ((prevNumb.Count() - 1) * 12), 14);
				prevNum.Text = prevNumb;
				operatorLabel.Text = $"{lastOperation}";
			}
			else
			{
				result = Convert.ToString(lastOp.Calc(prevNumb, currentNum));
				prevNumb = result;
				currentNum = null;
				currNum.Text = null;
				lastOperation = '-';
				prevNum.Location = new Point(322 - ((prevNumb.Count() - 1) * 12), 14);
				prevNum.Text = prevNumb;
				operatorLabel.Text = $"{lastOperation}";
			}
		}

		private void MultBtn_Click(object sender, EventArgs e)
		{
			if (prevNumb == null)
			{
				prevNumb = currentNum;
				currentNum = null;
				currNum.Text = null;
				lastOperation = 'X';
				prevNum.Location = new Point(322 - ((prevNumb.Count() - 1) * 12), 14);
				prevNum.Text = prevNumb;
				operatorLabel.Text = $"{lastOperation}";
			}
			else
			{
				result = Convert.ToString(lastOp.Calc(prevNumb, currentNum));
				prevNumb = result;
				currentNum = null;
				currNum.Text = null;
				lastOperation = 'X';
				prevNum.Location = new Point(322 - ((prevNumb.Count() - 1) * 12), 14);
				prevNum.Text = prevNumb;
				operatorLabel.Text = $"{lastOperation}";
			}
		}

		private void DivBtn_Click(object sender, EventArgs e)
		{
			if (prevNumb == null)
			{
				prevNumb = currentNum;
				currentNum = null;
				currNum.Text = null;
				lastOperation = '/';
				prevNum.Location = new Point(322 - ((prevNumb.Count() - 1) * 12), 14);
				prevNum.Text = prevNumb;
				operatorLabel.Text = $"{lastOperation}";
			}
			else
			{
				result = Convert.ToString(lastOp.Calc(prevNumb, currentNum));
				prevNumb = result;
				currentNum = null;
				currNum.Text = null;
				lastOperation = '/';
				prevNum.Location = new Point(322 - ((prevNumb.Count() - 1) * 12), 14);
				prevNum.Text = prevNumb;
				operatorLabel.Text = $"{lastOperation}";
			}
		}

		private void ResBtn_Click(object sender, EventArgs e)
		{
			result = Convert.ToString(lastOp.Calc(prevNumb, currentNum));
			currNum.Location = new Point(322 - ((result.Count() - 1) * 19), 49);
			currNum.Text = result.ToString();
		}

		private void CEBtn_Click(object sender, EventArgs e)
		{
			currentNum = "0";
			currNum.Text = "0";
			currNum.Location = new Point(322 - ((currentNum.Count() - 1) * 19), 49);
			prevNum.Text = null;
			operatorLabel.Text = null;
			lastOperation = null;
			result = null;
			prevNumb = null;
		}

		private void delBtn_Click(object sender, EventArgs e)
		{
			if (currentNum.Length >= 1)
			{
				currentNum = currentNum.Remove(currentNum.Length - 1);
				currNum.Text = currentNum;
				currNum.Location = new Point(322 - ((currentNum.Count() - 1) * 19), 49);
			}
		}

		private void pointBtn_Click(object sender, EventArgs e)
		{
			currNum.Text = numberSelecting(",");
			currNum.Location = new Point(320 - ((currentNum.Count() - 1) * 19), 49);
		}

		private void plusminusBtn_Click(object sender, EventArgs e)
		{
			if(!currentNum.Contains("-") && currentNum != null)
			{
				currentNum = string.Concat("-", currentNum);		
			} else if (currentNum.Contains("-"))
			{
				currentNum = currentNum.Remove(0,1);
			} else if (currentNum == null)
			{
				currentNum = "-";
			}
			currNum.Text = currentNum;
			currNum.Location = new Point(322 - ((currentNum.Count() - 1) * 19), 49);
		}

		private void Calculator_Load(object sender, EventArgs e)
		{
			currNum.Text = currentNum;
		}
	}
}
