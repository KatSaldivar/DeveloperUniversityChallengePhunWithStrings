using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePhunWithStrings
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 1.  Reverse your name.  In my case, the result would be: robaT boB
            /*
            StringBuilder sb = new StringBuilder();
            string name = "Bob Tabor";
            for (int i = name.Length - 1; i >= 0; i--)
                sb.Append(name[i]);
                
            resultLabel.Text = sb.ToString();
            */




            // 2.  Reverse this sequence: When you're finished it should look like this: Chewbacca,Han,Leia,Luke
            /*
            StringBuilder sb = new StringBuilder();
            string names = "Luke,Leia,Han,Chewbacca";
            string[] namesArray = names.Split(',');
            for (int i = namesArray.Length - 1; i >= 0; i--)
            {
                sb.Append(namesArray[i]);
                sb.Append(",");
            }
            string result = sb.ToString();
            resultLabel.Text = result.Remove(result.Length - 1, 1);
            */




            // 3. Use the sequence to create ascii art:
            // *****luke*****
            // *****leia*****
            // *****han******
            // **Chewbacca***
            /*
            StringBuilder sb = new StringBuilder();
            string names = "Luke,Leia,Han,Chewbacca";
            string[] namesArray = names.Split(',');
            for (int i = 0; i < namesArray.Length; i++)
            {
                int leftPad = (14 - namesArray[i].Length) / 2;
                namesArray[i] = namesArray[i].PadLeft(namesArray[i].Length + leftPad, '*');
                namesArray[i] = namesArray[i].PadRight(14, '*');
                sb.Append(namesArray[i]);
                sb.Append("<br />");
            }
            resultLabel.Text = sb.ToString();
            */




            // 4. Solve this puzzle:
            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD woMEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";
            // Once you fix it with string helper methods, it should read:
            // Now is the time for all good women to come to the aid of their country.
            
            string removeMe = "remove-me";
            int index = puzzle.IndexOf(removeMe);
            puzzle = puzzle.Remove(index, removeMe.Length);
            puzzle = puzzle.ToLower().Replace("z", "t");
            puzzle = puzzle.Remove(0, 1).Insert(0, "N");
            resultLabel.Text = puzzle;

        }
    }
}