using System;
using System.Windows.Forms;

namespace Lr2
{
    public partial class Form1 : Form
    {
        private OrderList orderList = new OrderList();
        private int currentIndex = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            string brand = brand_.Text;
            string Model = model.Text;
            int year = Convert.ToInt32(YYYY.Text);
            int month = Convert.ToInt32(MM.Text);
            int day = Convert.ToInt32(DD.Text);

            orderList.AddOrder(brand, Model, year, month, day);

            brand_.Text = "";
            model.Text = "";
            YYYY.Text = "";
            MM.Text = "";
            DD.Text = "";

            DisplayLastOrder();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (currentIndex < orderList.Count - 1)
            {
                currentIndex++;
                DisplayOrder(orderList[currentIndex]);
            }
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                DisplayOrder(orderList[currentIndex]);
            }
        }

        private void DisplayLastOrder()
        {
            Order lastOrder = orderList.GetLastOrder();
            if (lastOrder != null)
            {
                outbrand.Text = lastOrder.Brand;
                outmodel.Text = lastOrder.Model;
                outYYYY.Text = lastOrder.Year.ToString();
                outMM.Text = lastOrder.Month.ToString();
                outDD.Text = lastOrder.Day.ToString();
            }
        }

        private void DisplayOrder(Order order)
        {
            outbrand.Text = order.Brand;
            outmodel.Text = order.Model;
            outYYYY.Text = order.Year.ToString();
            outMM.Text = order.Month.ToString();
            outDD.Text = order.Day.ToString();
        }
    }

    public class Order
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
    }

    public class OrderNode
    {
        public Order Order { get; set; }
        public OrderNode Next { get; set; }
    }

    public class OrderList
    {
        private OrderNode head;

        public int Count { get; private set; }

        public void AddOrder(string brand, string model, int year, int month, int day)
        {
            OrderNode newNode = new OrderNode
            {
                Order = new Order
                {
                    Brand = brand,
                    Model = model,
                    Year = year,
                    Month = month,
                    Day = day
                },
                Next = null
            };

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                OrderNode current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }

            Count++;
        }

        public Order GetLastOrder()
        {
            OrderNode current = head;
            Order lastOrder = null;

            while (current != null)
            {
                lastOrder = current.Order;
                current = current.Next;
            }

            return lastOrder;
        }

        public Order this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }

                OrderNode current = head;
                for (int i = 0; i < index; i++)
                {
                    current = current.Next;
                }

                return current.Order;
            }
        }
    }
}
