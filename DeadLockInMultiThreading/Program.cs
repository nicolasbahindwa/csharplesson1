using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DeadLockInMultiThreading
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("main has started");
            account accA = new account(100, 200);
            account accB = new account(102, 300);

            AccountManager accManagerA = new AccountManager(accA, accB, 1000);
            Thread T1 = new Thread(accManagerA.transfer);
            T1.Name = "T1";

            AccountManager accManagerB = new AccountManager(accA, accB, 2000);
            Thread T2 = new Thread(accManagerB.transfer);
            T1.Name = "T2";

            T1.Start();
            T2.Start();

            T1.Join();
            T2.Join();

            Console.WriteLine("main has completed");


        }

    }
    public class account
    {
        double _balance;
        int _id;

        public account(int id, double balance)
        {
            this._balance = balance;
            this._id = id;
        }
        public int ID
        {
            get { return _id; }
        }

    
    
    }

    public class AccountManager
    {

        account _fromAccount; account _toAccount;double _amountToTransfer;

        public AccountManager(account fromAmount, account toAmount,double amountToTransfer)
        {
            this._fromAccount = fromAmount;
            this._toAccount = toAmount;
            this._amountToTransfer = amountToTransfer;
        }

        public void Transfer()
        {
            lock (_fromAccount)
            {
                Thread.Sleep(1000);
                lock (_toAccount)
                {
                    _fromAccount.Withdraw(_amountToTransfer);
                    _toAccount.deposit(_amountToTransfer);
                }

            }
        }
    }
}
