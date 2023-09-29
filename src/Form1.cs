using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace calcu
{
    public partial class Form1 : Form
    {
        int ipn = 0;
        double n = 0;//number
        int xs = 0;//判断小数位
        double result = 0;
        char c = '\0'; //运算符号
        string strp = "";
        string strn = "";

        ArrayList nlist = new ArrayList();//数表
        ArrayList clist = new ArrayList();//符表

        Stack<double> numstack = new Stack<double>();//数栈
        Stack<char> cstack = new Stack<char>();//符栈

        public Form1()
        {
            InitializeComponent();
        }

        public void refresh()
        {
            op.Text = strp;//刷新显示
        }
        public int findn()//最前面有没有输入东西
        {
            string findstr = op.Text;//获取输出框里的文本
            if (findstr != "")
            {
                return 1;
            }
            return 0;
        }
        public int findc()//最后面有没有输入符号防止有两个符号
        {
            string findstr = op.Text;
            int l = findstr.Length;
            if ((findstr[l - 1] >= '0' && findstr[l - 1] <= '9') || findstr[l - 1] == ')')//除了负数的右括号可以输入
            {
                return 1;
            }
            return 0;
        }
        public void numbutton_Click(object sender, EventArgs e)//按数字键
        {
            ipn = ((Button)sender).TabIndex;//获取按钮代表的值
            if (xs == 0)
            {
                n = n * 10 + ipn;
            }
            else if(xs>0)
            {
                n = n + ipn * Math.Pow(0.1, xs);
                xs++;
            }
            strp += Convert.ToString(ipn);//多显示一位新的数字
            refresh();
            ipn = 0;
        }
        public void cbutton_Click(object sender, EventArgs e)//按运算符号键+-*/%
        {
            if (findn() != 0 && findc() != 0)
            {
                c = Convert.ToChar(((Button)sender).Text);//获取按钮代表的符号
                nlist.Add(n);//每有一个符号输入就把n输入数(下面等于也要）
                clist.Add(c);
                strp += ((Button)sender).Text;
                refresh();
                n = 0;
                xs = 0;
            }

        }
        public void xsd_Click(object sender, EventArgs e)
        {
            if (xs == 0)
            {
                xs = 1;
                strp += ".";
                refresh();
            }
        }

        public void ac_Click(object sender, EventArgs e)
        {
            n = 0;
            xs = 0;
            c = '\0';
            result = 0;
            strp = "";
            refresh();
            cclear();
        }

        public double jisuan()
        {
            char a;
            double b;
            double d;
            while (nlist.Count != 0)
            {
                b = (double)nlist[0];
                nlist.RemoveAt(0);
                numstack.Push(b);
            ysf:
                if (clist.Count == 0)
                {
                    break;
                }
                a = (char)clist[0];
                clist.RemoveAt(0);
                switch (a)
                {
                    case '+':
                        cstack.Push(a);
                        break;
                    case '-':
                        cstack.Push(a);
                        break;
                    case '*':
                        b = (double)nlist[0];
                        nlist.RemoveAt(0);
                        d = numstack.Pop();
                        d = b * d;
                        numstack.Push(d);
                        goto ysf;
                    case '/':
                        b = (double)nlist[0];
                        nlist.RemoveAt(0);
                        d = numstack.Pop();
                        if(b==0)
                        {
                            MessageBox.Show("div 0 error!");
                            goto err;
                        }
                        d = d / b;
                        numstack.Push(d);
                        goto ysf;
                    case '%':
                        b = (double)nlist[0];
                        nlist.RemoveAt(0);
                        d = numstack.Pop();
                        d = d % b;
                        numstack.Push(d);
                        goto ysf;
                }
            }
            d = 0;
            while (numstack.Count != 1)
            {
                b = numstack.Pop();
                a = cstack.Pop();
                if (a == '+')
                {
                    d = d + b;
                }
                else if (a == '-')
                {
                    d = d - b;
                }
            }
            b = numstack.Pop();
            d = d + b;
            return d;
        err:
            return 0;
        }
        public void fh_Click(object sender, EventArgs e)
        {
            if (findn() != 0 && findc() != 0 && n != 0)
            {
                strn = Convert.ToString(n);
                int l1 = strp.Length;
                int l2 = strn.Length;
                n = n * -1;
                if (n < 0)
                {
                    strp = strp.Substring(0, l1 - l2);
                    strn = Convert.ToString(n);
                    strp += "(";
                    strp += strn;
                    strp += ")";
                }
                else if (n > 0)
                {
                    strp = strp.Substring(0, l1 - l2 - 2);
                    strn = Convert.ToString(n);
                    strp += strn;

                }
                refresh();
            }

        }
         public void del_Click(object sender, EventArgs e)
        {
            if(findn()!=0)
            {
                string findstr = op.Text;//获取输出框里的文本
                int l = findstr.Length;
                if (findstr[l - 1] >= '0' && findstr[l - 1] <= '9')//删除数字
                {
                    double n2;
                    if (nlist.Count > 0)
                    { 
                        n2 = (double)nlist[nlist.Count - 1];
                        if (n == n2)
                        {
                            nlist.RemoveAt(nlist.Count - 1);
                        }
                    } 
                    string b = Convert.ToString(n);
                    b = b.Substring(0, b.Length - 1); 
                    if (xs > 0)
                    {
                        xs--;
                    }
                    if (b != "") n = Convert.ToDouble(b);
                    else if (b == "") n = 0;
                    strp = strp.Substring(0, l - 1);
                    refresh();
                }
                else//删除符号
                {
                    char d = findstr[l - 1];
                    if (d == '.')
                    {
                        xs = 0;
                        strp = strp.Substring(0, l - 1);
                        refresh();
                    }
                    else if (d == '+' || d == '-' || d == '*' || d == '/' || d == '%')
                    {
                        clist.RemoveAt(clist.Count - 1);
                        strp = strp.Substring(0, l - 1);
                        refresh();
                        n = (double)nlist[nlist.Count - 1];
                        nlist.RemoveAt(nlist.Count - 1);
                    }
                    else if (d == ')')
                    {
                        string b = Convert.ToString(n);
                        strp = strp.Substring(0, l - b.Length - 2);
                        n = n * -1;
                        b = Convert.ToString(n);
                        strp += b;
                        refresh();
                    }
                }
            }
            
        }
        public void dy_Click(object sender, EventArgs e)
        {
            if(findc()!=0)
            {
                nlist.Add(n);
                result = jisuan();
                strp = result.ToString("0.##########");
                refresh();
                n = result;
                result = 0;
            }
            cclear();
        }
        public void cclear()
        {
            numstack.Clear();
            cstack.Clear();
            nlist.Clear();
        }
    }
}