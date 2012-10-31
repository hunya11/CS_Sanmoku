using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_Sanmoku {
	class Cell {
		private int num_status;
		public int NumStatus {
			get { return num_status; }
			set {
				if(value != 0 || value != 1) {
					if(num_status == 2) {
						num_status = value;
					}					
				}
			}
		}

		public Cell() {
			num_status = 2;
		}

	}
}
