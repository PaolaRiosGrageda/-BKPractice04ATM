﻿namespace Jalasoft.DevLEvel1.Practice04
{
    public interface IAccount
    {
        void Deposit (int money);
        double Withdraw(double money);
        void ShowOperation();
        void ShowOperation(double mount);
        void ShowBalance ();


    }
}