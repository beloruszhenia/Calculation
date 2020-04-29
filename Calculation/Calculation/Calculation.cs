using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    class Calculation
    {
        int a, b;
        char sign = ' ';
        string nums = " 1234567890";        
        string signs = "+-*/";        

        string aa = "";
        string bb = "";
        string ss = "";
        bool err;

        public string CalcStr { get; set; } = "";

        public int GetRes()
        {
            int sc = 1;
            //Analiz ns simvoly
            for (int i = 0; i < CalcStr.Length; i++)
            {
                switch (sc)
                {
                    case 1:  //aa
                        {
                            if (i==0 && CalcStr[0] == '-')
                            {
                                aa += CalcStr[i];
                                break;

                            }

                            if (nums.IndexOf(CalcStr[i]) != -1)
                            {
                                aa += CalcStr[i];
                            }
                            else
                            {
                                i--;
                                sc = 2;
                            }
                            break;
                        }
                    case 2: //ss
                        {
                            if (signs.IndexOf(CalcStr[i]) != -1)
                            {
                                ss += CalcStr[i];
                                sc = 3;
                            }
                            else
                            {
                                err = true;
                            }
                            break;
                        }
                    case 3: //bb
                        {
                            if (nums.IndexOf(CalcStr[i]) != -1)
                            {
                                bb += CalcStr[i];
                            }
                            else
                            {
                                err = true;
                            }
                            break;                            
                        }                
                                
                }

            }

            if (err)
            {
                return 0;
            }

            //konvertacia
            if (!int.TryParse(aa, out a)) err = true;
            if (!int.TryParse(bb, out b)) err = true;
            //Vychyslenie

            if (err)
            {
                return 0;
            }

            int rr;
            switch (ss[0])
            {
                case '+':
                    {
                        rr = a + b;
                        break;
                    }
                case '-':
                    {
                        rr = a - b;
                        break;
                    }
                case '*':
                    {
                        rr = a * b;
                        break;
                    }
                case '/':
                    {
                        rr = a / b;
                        break;
                    }
                default: rr = 0;
                    break;

            }

            return rr;

        }

    }
}
