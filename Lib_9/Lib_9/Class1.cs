
using System.Windows.Media;

namespace Lib_9
{
    public class Class_9
    {
        /// <summary>
        /// ���������� ������������ ����� � ������ ������ � ���� ������
        /// </summary>
        /// <param name="mas"> �������� �������</param>
        /// <param name="maxSum"> ��������� ������������ �����</param>
        /// <param name="maxRow"> ��������� ����� ������ � ����.������</param>
        public  void Func_Calc(in int[,] mas, out int maxSum, out int maxRow)
        {
            maxSum = 1;  
            maxRow = 0;  

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                int rowSum = 0;  
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    rowSum += mas[i, j];
                }
                if (rowSum > maxSum)
                {
                    maxSum = rowSum;  
                    maxRow = i + 1;  
                }
                
            }
            
            
           
            
        }
        /// <summary>
        /// ���������� �������
        /// </summary>
        /// <param name="n"> �������� ����� �����</param>
        /// <param name="m"> �������� ����� ��������</param>
        /// <returns> ������������ ������</returns>
        public  int[,] Func_Input(in int n, in int m)
        {
            Random rnd = new Random();
            int[,] mas = new int[n,m];
            
            for(int i = 0;i < mas.GetLength(0); i++)
            {
                for(int j = 0;j < mas.GetLength(1); j++)
                {
                    int a = rnd.Next(1,10);
                    mas[i,j] = a;
                }
            }
            return mas;
        }
    }

}
