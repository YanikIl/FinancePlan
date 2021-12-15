﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Contribution
    {
        public string Nazvanie { get; set; }
        public int Summ { get; set; }

        public string Date { get; set; } // календарик для впф // 05/05/2021
        public int TermOfDeposit { get; set; } // срок вклада в месяцах // 12
        public double Procent { get; set; }
        //public abstract double SummaPopolneniya { get; set; }
        //public abstract double SummaSnyatiyaiya { get; set; }
        public Contribution(string name, int summ, string date, int termofdeposit, double procent) /*double summapopolneniya*/ /*double summasnyatiyaiya*/
        {

            Nazvanie = name;
            Summ = summ;
            Date = date;
            TermOfDeposit = termofdeposit;
            Procent = procent;
            //SummaPopolneniya = summapopolneniya;
            //SummaSnyatiyaiya = summasnyatiyaiya;
        }

        #region
        //public string WriteName()
        //{
        //    return Name;
        //}
        //public double WriteSumm()
        //{
        //    return Summ;
        //}
        //public string WriteDate()
        //{
        //    return Date;
        //}
        //public int WriteTermOfDeposit()
        //{
        //    return TermOfDeposit;
        //}
        //public double WriteProcent()
        //{
        //    return Procent;
        //}
        #endregion 


        //дата открытия вклада //
        public string DataToStart()
        {
            string newdata = Date.Substring(3, 10);
            return newdata;
        }


        //дата закрытия вклада //если 2100 год тесты?
        public string DataToEnd()
        {
            string newday = Date.Substring(3, 2); // "чт 12.11.2020"   05
            int newmonth = Convert.ToInt32(Date.Substring(6, 2)) + TermOfDeposit; // 11 + 13 = 24       05 + 13 = 18
            int plusyear = newmonth / 12; // 24 / 12 = 2
            int newyear = Convert.ToInt32(Date.Substring(11, 2)) + plusyear; // 20 + 2 = 2022
            newmonth = (newmonth % 12); // 24 % 12 = 0
            string newmonth2 = Convert.ToString(newmonth % 12);
            //string newmonth2 = "0";
            if (newmonth == 0)
            {
                newmonth2 = "01";
            }
            else if (newmonth < 10)
            {
                newmonth2 = "0" + Convert.ToString(newmonth);
            }
            string newdata = (newday) + "." + newmonth2 + "." + Convert.ToString(newyear);
            return newdata;
        }


        // метод изменения месяца (прибавляет один месяц)  в дате //тесты?
        public string ChangeMonthInDate()
        {
            //"чт 05.05.2020"
            string newday = Date.Substring(3, 2); //чт 05
            int month = Convert.ToInt32(Date.Substring(6, 2)); // 5
            int newmonth = Convert.ToInt32(Date.Substring(6, 2)) + 1; // 05 + 1 = 6  //11 + 1 = 12 //12 + 1 = 13
            string newmonth2 = Convert.ToString(newmonth % 12); // "6" 
            if (newmonth == 12)
            {
                newmonth2 = "12";
            }
            if (newmonth == 13)
            {
                newmonth = 13 % 12;
            }
            if (newmonth < 10)
            {
                newmonth2 = "0" + Convert.ToString(newmonth);
            }

            // "06"
            int newyear = Convert.ToInt32(Date.Substring(11, 2)); //2020

            if (month == 12)
            {
                newyear = newyear + 1;
            }
            string newdatamonth = (newday) + "." + newmonth2 + "." + Convert.ToString(newyear);
            return newdatamonth;
        }

        // метод изменения месяца (прибавляет один месяц)
        public int ChangeMonth(int data)
        {
            int newmonth = data + 1; // 5 + 1 = 6  //11 + 1 = 12 //12 + 1 = 13

            if (newmonth == 13)
            {
                newmonth = 13 % 12;
            }
            return newmonth;
        }


        // день открытия вклада
        public string DayOpenContribution()
        {
            string newday = Date.Substring(3, 2);
            return newday;
        }


        //день на данный момент для сравнения
        public string DayToNow()
        {
            DateTime today = DateTime.Now;
            string today2 = Convert.ToString(today); //"чт 09.07.20 20:04"
            string today3 = today2.Substring(3, 2); // 09.07.20 = 09
            return today3; // 09
        }

        //дата на данный момент для сравнения
        public string DataToNow()
        {
            DateTime today = DateTime.Now;
            string today2 = Convert.ToString(today); //"чт 09.07.20 20:04"
            string today3 = today2.Substring(3, 8); // 09.07.20
            return today3;
        }

        //месяц сегодняшней даты
        public string DataMonthToNow()
        {
            DateTime today = DateTime.Now;
            string today2 = Convert.ToString(today); //"чт 09.07.20 20:04"
            string today3 = today2.Substring(6, 2); //07
            return today3;
        }

        //месяц открытия вклада
        public string DataMonthToDate()
        {
            string today = Date;
            string today2 = Convert.ToString(today); //"чт 08.06.2020"
            string today3 = today2.Substring(6, 2); // 06
            return today3;
        }

        //начисление процентов
        public abstract int PlusProcent();
    }
}
