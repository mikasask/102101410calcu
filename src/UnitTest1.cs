using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace calcu
{
    [TestClass]
    public class UnitTest11
    {

        [TestMethod]
        public void addsub()
        {
            Form1 form = new Form1();

            form.numbutton_Click(form.button1, null);//1
            form.cbutton_Click(form.add, null);//+
            form.numbutton_Click(form.button2, null);//2
            form.cbutton_Click(form.sub, null);//-
            form.numbutton_Click(form.button4, null);//4
            form.cbutton_Click(form.add, null);//+
            form.numbutton_Click(form.button6, null);//6
            form.dy_Click(form.dy, null);//=
            Assert.AreEqual("5", form.op.Text);
        }
        [TestMethod]
        public void addsubmuldivxs()
        {
            Form1 form = new Form1();

            form.numbutton_Click(form.button1, null);//1
            form.xsd_Click(form.xsd, null);//.
            form.numbutton_Click(form.button2, null);//2
            form.cbutton_Click(form.add, null);//+
            form.numbutton_Click(form.button2, null);//2
            form.cbutton_Click(form.mul, null);//*
            form.numbutton_Click(form.button4, null);//4
            form.cbutton_Click(form.div, null);///
            form.numbutton_Click(form.button5, null);//5
            form.dy_Click(form.dy, null);//=
            Assert.AreEqual("2.8", form.op.Text);
        }

    }
}