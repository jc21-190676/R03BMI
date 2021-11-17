using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace R03BMI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            creater.Text = "JK3A18 佐藤　柊輔";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double height = double.Parse(heighit.Text); //身長
            double weight = double.Parse(weighit.Text); //体重
            string heightUnit = "m";
            string weightUnit = "kg";
            
            if(height > 3)  //cmをｍに変換
            {  
                height /= 100;
                heightUnit = "cm";
            }
            
            if(weight > 600) //gをkgに変換
            {
                weight/=1000;
                weightUnit = "g";
            }

            double bmi =weight / (height*height);
            bmi = Math.Round(bmi,1);

            string BMIStatus = BMI_Check(bmi); 
            
            string text =　"身長"+heighit.Text+heightUnit;
            text += ",体重"+weighit.Text+weightUnit; 

            result.Text = text + "の人のBMIは、"+bmi+BMIStatus;
        }

        private string BMI_Check(double bmi)    //bmiを元に体の状態(例：普通体重,低体重)を返す
        {
            string BMIStatus;

            if(bmi < 18.5)
            {
                BMIStatus = "低体重(痩せ)";
            }else if(bmi < 25.0)
            {
                BMIStatus = "普通体重";
            }else if(bmi < 30.0)
            {
                BMIStatus = "肥満(1度)";
            }else if(bmi < 35.0)
            {
                BMIStatus = "肥満(2度)";
            }else if(bmi < 40)
            {
                BMIStatus = "肥満(3度)";
            }else
            {
                BMIStatus = "肥満(4度)";
            }

            return BMIStatus;
        }
    }
}
