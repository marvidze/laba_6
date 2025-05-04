using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_6
{
    public class AsyncOperations
    {
        /// <summary>
        /// Метод для расчета среднего значения вектора
        /// </summary>
        /// <param name="vector">Вектор, в котором будем искать среднее значение</param>
        /// <returns>Среднее значение вектора</returns>
        public async Task<double> CalculateVectorAverageAsync(List<double> vector)
        {
            return await Task.Run(() =>
            {
                if (vector == null || vector.Count == 0)
                    return 0;

                double sum = 0;
                foreach (var num in vector)
                {
                    sum += num;
                }
                return sum / vector.Count;
            });
        }

        /// <summary>
        /// Метод для вывода текущего времени
        /// </summary>
        /// <returns>Время в формаате часы: минуты: секунды</returns>
        public async Task<string> GetCurrentTimeAsync()
        {
            return await Task.Run(() =>
            {
                return DateTime.Now.ToString("HH:mm:ss");
            });
        }

        /// <summary>
        /// Метод для вычисления факториала
        /// </summary>
        /// <param name="n">Число из которого вычисляется факториал</param>
        /// <returns>Факториал числа</returns>
        public async Task<long> CalculateFactorialAsync(int n)
        {
            return await Task.Run(() =>
            {
                if (n < 0)
                    return 0;

                long result = 1;
                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }
                return result;
            });
        }
    }
}
