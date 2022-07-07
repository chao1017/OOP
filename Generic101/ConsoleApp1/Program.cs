// See https://aka.ms/new-console-template for more information
Console.WriteLine("泛型Demo");
PlaneFactory planeFactory = new PlaneFactory();
planeFactory.Start();
Console.ReadLine();

class JetFighter
{
    public JetFighter()
    {
        Console.WriteLine("製造一架噴射戰鬥機");
    }
}

class Helicopter
{
    public Helicopter()
    {
        Console.WriteLine("製造一架直昇機");
    }
}

class Airliner
{
    public Airliner()
    {
        Console.WriteLine("製造一架民航客機");
    }
}


class PlaneFactory
{
    /// <summary>
    /// constructor
    /// </summary>
    public PlaneFactory()
    {
        Console.WriteLine("這是一間飛機工廠");
    }

    public void Start()
    {
        Console.WriteLine("飛機工廠開始運作");
        GenericPlaneMaker genericPlaneMaker = new GenericPlaneMaker();

        genericPlaneMaker.GetPlane<JetFighter>();
        genericPlaneMaker.GetPlane<Airliner>();
        genericPlaneMaker.GetPlane<Helicopter>();
    }

    class GenericPlaneMaker
    {
        public GenericPlaneMaker()
        {
            Console.WriteLine("飛機工廠建立完成");
        }

        public object GetPlane<T>() where T : new()
        {
            Console.WriteLine("造一架飛機");
            return new T();
        }
    }

    class JetFighterMaker
    {
        public JetFighterMaker()
        {
            Console.WriteLine("噴射戰鬥機工廠建立完成。");
        }

        public JetFighter GetJetFighter()
        {
            Console.WriteLine("噴射戰鬥機建立完成");
            return new JetFighter();
        }
    }

    class HelicopterMaker
    {
        public HelicopterMaker()
        {
            Console.WriteLine("直昇機工廠建立完成。");
        }

        public Helicopter GetHelicopter()
        {
            Console.WriteLine("直昇機建立完成");
            return new Helicopter();
        }
    }

    class AirLinerMaker
    {
        public AirLinerMaker()
        {
            Console.WriteLine("民航機建立完成。");            
        }

        public Airliner GetAirliner()
        {
            Console.WriteLine("民航機建立完成");
            return new Airliner();
        }
    }
}
