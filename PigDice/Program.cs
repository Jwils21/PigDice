using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDice {
	class Program {

		Random rnd = new Random();

		int RollDie() {
			return rnd.Next(1, 7);
		}

		void PlayPigDice() {
			int score = 0;
			int die = RollDie();
			while(die != 1) {
				score += die;
				die = RollDie();
			}
			Console.WriteLine("Score is {0}", score);
		}

		void PlayPigDiceAutomated() {
			long GameNums = 0;
			int HighScore = 0;
			while(GameNums < 1000000) {
				int score = 0;
				int die = RollDie();
				while(die != 1) {
					score += die;
					die = RollDie();
				}
				GameNums += 1;
				if(HighScore < score) {
					HighScore = score;
				}
				score = 0;
				
			}
			Console.WriteLine("# of games: {0}, Score is {1}", GameNums, HighScore);
		}

		void Run() {
			bool quit = false;
			while(!quit) {
				PlayPigDice();

				Console.Write("Do you want to quit? ");
				string answer = Console.ReadLine();
				answer = answer.ToUpper();
				quit = answer.StartsWith("Y");
			}
		}
		static void Main(string[] args) {
			//(new Program()).Run();
			(new Program()).PlayPigDiceAutomated();
		}
	}
}