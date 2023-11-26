namespace FactoryMethodDesignMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public interface IButton
    {
        void Render();
        void onClick();
    }

    public class WindowsButton : IButton
    {
        public void onClick()
        {
            throw new NotImplementedException();
        }

        public void Render()
        {
            throw new NotImplementedException();
        }
    }



    public class HtmlButton : IButton
    {
        public void onClick()
        {
            throw new NotImplementedException();
        }

        public void Render()
        {
            throw new NotImplementedException();
        }
    }

    public abstract class Dialog
    {
        public void Render()
        {
            //some
        }

        abstract public IButton creatButton();

    }



    public class WindowsDialog : Dialog
    {
        public override IButton creatButton()
        {
            return new WindowsButton();
        }
    }


    public class WebDialog : Dialog
    {
        public override IButton creatButton()
        {
            return new HtmlButton();
        }
    }
}