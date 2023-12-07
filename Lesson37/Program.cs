Tel tel1 = new Tel(4,6.8,3.6);
//tel.day = 6;
//tel.time = 5.3;
//tel.cost = 3.5;
Console.WriteLine($"{tel1.Time}*{tel1.Cost}={tel1.Salary():F2}");
tel1.Time = 10;
Console.WriteLine($"{tel1.Time}*{tel1.Cost}={tel1.Salary():F2}");
Tel tel2 = new Tel();
Console.WriteLine($"{tel2.Time}*{tel2.Cost}={tel2.Salary():F2}");
tel2.Cost=5.8;
Console.WriteLine($"{tel2.Time}*{tel2.Cost}={tel2.Salary():F2}");
class Tel
{
    private int day;
    private double time;
    private double cost;
    public int Day
    {
        get { return day; }
        set { day = value; }
    }
    public double Time
    {
        get { return time; }
        set { time = value; }
    }
    public double Cost
    {
        get { return cost; }
        set { cost = value; }
    }
    public Tel(int day, double time, double cost)
    {
        this.day = day;
        this.time = time;
        this.cost = cost;
    }

    public Tel()
    {
        this.day = 0;
        this.time = 0;
        this.cost = 0;
    }
    //public double getTime()
    //{
    //    return this.time;
    //}
    //public double getCost() { 
    //    return this.cost;
    //}
    //public void setTime(double time)
    //{
    //    this.time = time;
    //}
    //public void setCost(double cost)
    //{
    //    this.cost = cost;
    //}
    public double Salary()
    {
        if(day>=1&&day<=5)
            return time*cost;
        return time*cost-(time*cost)*0.1;
    }
}