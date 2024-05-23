using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Week_8_Junk_Notes
{
    public class Data
    {
        public static string BuissnessName = "Mike's Sandwich Shop";

        public static string gameFranchise = "Pokemon Mystery Dungeon: Explorers of Time";


        //Observable Collection
        public static ObservableCollection<string> names = new ObservableCollection<string>();

        string myName = "LitoNation";

        public static ObservableCollection<string> supernames = new ObservableCollection<string>();



        //Static Contructor
         static Data()
         {

            MessageBox.Show("It's the end of the world as we know it :B");
            names.Add("Rafael");
            names.Add("Toivo");
            names.Add("Charles");
            names.Add("Will");

            supernames.Add("SuperRafael");
            supernames.Add("SuperToivo");
            supernames.Add("SuperCharles");
            supernames.Add("SuperWill");
         }


        public static void AddName(string name)
        {
            names.Add(name);
        }
        //make sure to put in public so it shows up on all windows

        //public static void ChangeMyName(Data name,string newName)
        //{
        //    name.myName=(newName);
        //}

    }// class




}//namespace
