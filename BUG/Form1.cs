using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// ARRAY LIST
using System.Collections;

namespace BUG
{
    public partial class Form1 : Form
    {
        string[] arrBugState = new string[3];
        DataTable dtPCondition = new DataTable();
        DataTable dtResult = new DataTable();
        int intTime = 0;
        public Form1()
        {
            InitializeComponent();
        }

        // Input: Array [Extended Function]
        private string ConvertCharToString(char[] array)
        {
            StringBuilder builder = new StringBuilder();
            foreach (char value in array)
            {   builder.Append(value);  }
            return builder.ToString();
        }

        // Input: Number of Bug and Length of All eg. 3 of 4
        private string setBugState(int intNoBug, int intLegth)
        {
            char[] arrBugPattern = new char[intLegth];
            for (int i = 0; i < intLegth; i++)
            {
                if (i >= intNoBug)
                { arrBugPattern[i] = '-'; }
                else
                { arrBugPattern[i] = '+'; }
            }
            return ConvertCharToString(arrBugPattern);
        }

        // Input: Codition and BugValue
        private bool checkBugCondition(string strCondition, string strBug) 
        {
            bool boolMatch = true;
            char[] arrConditionChar = strCondition.ToCharArray();
            char[] arrBug = strBug.ToCharArray();

            if(arrBug.Length == arrConditionChar.Length)
            {
                for (int i = 0; i < arrConditionChar.Length; i++)
                {
                    if (arrConditionChar[i] != '0') // Not Ignore
                    {
                        if (arrConditionChar[i] == '-')
                        {
                            if (arrBug[i] == '+')
                            { boolMatch = false; }
                        }
                        else if (arrConditionChar[i] == '+')
                        {
                            if (arrBug[i] == '-')
                            { boolMatch = false; }
                        }
                    }
                }
            }
            
            return boolMatch;
        }

        // Input : ConditionResult and BugValue
        private string calculateResult(string strConditionResult, string strBug) 
        {
            char[] arrConditionResult = strConditionResult.ToCharArray();
            char[] arrBug = strBug.ToCharArray();
            char[] arrResult = new char[arrBug.Length];

            for (int i = 0; i < arrBug.Length; i++) 
            {
                if ((arrBug[i] == '+') && (arrConditionResult[i] == '-')) // Reduce bug
                { arrResult[i] = '-'; }
                else if ((arrConditionResult[i] == '+')) // Add bug
                { arrResult[i] = '+'; }
                else
                { arrResult[i] = arrBug[i]; }                
            }
            return ConvertCharToString(arrResult);
        }

        // Input: All-Condition and Mode
        private string getValueOfCondition(string strCondition, string strOption)
        {
            string[] arrCondition = strCondition.Split(' ');
            if (strOption == "T")
            { return arrCondition[0]; }
            else if (strOption == "C")
            { return arrCondition[1]; }
            else if (strOption == "R")
            { return arrCondition[2]; }
            else
            { return ""; }
        }

        // Input: Array Bug
        private bool checkBugNone(char[] arrBug)
        {
            bool bookBugNone = true;
            for (int i = 0; i < arrBug.Length; i++)
            {
                if (bookBugNone == false)
                { break; }

                if (arrBug[i] == '+')
                { bookBugNone = false; }
            }
            return bookBugNone;
        }

        private bool checkSameLastPath(string strNowCondition)
        {
            bool boolSame = false;

            if (dtResult.Rows.Count > 0)
            {
                if ((dtResult.Rows[dtResult.Rows.Count - 1]["Codition"].ToString() != strNowCondition))
                { boolSame= true; }
                else
                {
                    if (dtResult.Rows.Count >= 2)
                    {
                        if ((dtResult.Rows[dtResult.Rows.Count - 2]["Codition"].ToString() != strNowCondition))
                        { boolSame= true; }
                    }
                }                
            }
            else
            { boolSame= true; }

            return boolSame;
        }

        private bool checkExit()
        {
            bool boolSame = true;

            if (dtResult.Rows.Count > 0)
            {
                if (checkBugNone(dtResult.Rows[dtResult.Rows.Count - 1]["Result"].ToString().ToCharArray()) == true)
                { boolSame = false; }
            }

            return boolSame;
        }

        // Event 'ADD' Click
        private void btnAddCondition_Click(object sender, EventArgs e)
        {
            if (dtPCondition.Columns.Count == 0)
            { dtPCondition.Columns.Add("Condition", typeof(string)); }

            if (dtPCondition.Rows.Count < Convert.ToInt16(txtNoCondition.Text)) // Input not more than config number of Path
            {
                DataRow dr = dtPCondition.NewRow();
                dr["Condition"] = txtCondition.Text;
                dtPCondition.Rows.Add(dr);

                gridCondition.DataSource = dtPCondition.DefaultView;
                gridCondition.Refresh();

                txtCondition.Text = "";
            }
        }

        // Event 'Process' Click
        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (dtResult.Columns.Count == 0)
            { 
                dtResult.Columns.Add("Input", typeof(string));
                dtResult.Columns.Add("Codition", typeof(string));
                dtResult.Columns.Add("Result", typeof(string));
                dtResult.Columns.Add("Time", typeof(string));
            }

            string strBug = setBugState(Convert.ToInt16(txtNoBug.Text), Convert.ToInt16(txtNoCondition.Text));
            Process(strBug);
        }

        private void Done()
        {
            gridResult.DataSource = dtResult.DefaultView;
            gridResult.Refresh();

            int intTime = 0;
            for(int i = 0; i<dtResult.Rows.Count;i++)
            {intTime += Convert.ToInt16(dtResult.Rows[i]["Time"].ToString());}

            txtTime.Text = intTime.ToString();
        }

        private void Process(string strBug)
        {
            if (checkBugNone(strBug.ToCharArray()) == false)
            {
                for (int i = 0; i < dtPCondition.Rows.Count; i++)
                {
                    if (checkExit())
                    {
                        string strCondition = getValueOfCondition(dtPCondition.Rows[i]["Condition"].ToString(), "C");
                        if (checkSameLastPath(strCondition)) // not allow use 2 time as near by 
                        {
                            if (checkBugCondition(strCondition, strBug) == true) // Can use this path
                            {
                                string strConditionResult = getValueOfCondition(dtPCondition.Rows[i]["Condition"].ToString(), "R");
                                string strResult = calculateResult(strConditionResult, strBug);
                                string strTime = getValueOfCondition(dtPCondition.Rows[i]["Condition"].ToString(), "T");
                                intTime += Convert.ToInt16(strTime);

                                DataRow dr = dtResult.NewRow();
                                dr["Input"] = strBug;
                                dr["Codition"] = strCondition;
                                dr["Result"] = strResult;
                                dr["Time"] = strTime;
                                dtResult.Rows.Add(dr);

                                if (checkBugNone(strResult.ToCharArray()) == false)
                                { Process(strResult); }
                                else
                                {
                                    Done();
                                    break;
                                }
                            }
                        }
                    }
                    else
                    { break; }
                }
            }
            
        }
    }
}
