/* Homework 9. Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
 Даны два неотрицательных числа m и n. 
m = 3, n = 2 -> A(m,n) = 29  */

int Ack(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ack(m - 1, 1);
    }
    else
    {
        return Ack(m - 1, Ack(m, n - 1));
    }

}
Console.WriteLine(Ack(3, 2));

 int rec2(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        } 
        else if (n == 0 && m > 0) // Шаг рекурсии  
        {
            return rec2(m - 1, 1);
        } 
        else
        {
            return rec2(m - 1, rec2(m, n - 1));//  рекурсивное условие
        }
    }
    Console.Write(rec2(3, 2));







   /*  int Ack(TreeNode tn, int n, int m)
        {
            if (tek_step > 2000) return 0;
            TreeNode tek_tn = tn.Nodes.Add(String.Format("{0},{1}", n, m));

            int val=0;

            if (n == 0)
            {
                val = m + 1;
            }
            else if (m == 0)
            {
                val = Ack(tek_tn,n - 1, 1);
            }
            else
            {
                val = Ack(tek_tn,n - 1, Ack(tek_tn,n, m - 1));
            }
         tek_tn.Text = String.Format("{0},{1}={2}", n, m,val);
          return val;
        }

         void button124_Click(object sender, EventArgs e)
        {
            TreeNode tn = treeView2.Nodes.Add("Start");
            textBox3.Text = Ack(tn, int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();

        } */





