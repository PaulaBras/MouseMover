using System.Windows.Forms;
using System.Threading;

namespace MouseMover
{
    class Moving
    {
        public static void Move()
        {
            while (MainWindow.running == true)
            {
                System.Drawing.Point CurPosition;
                CurPosition = Cursor.Position;
                if(MainWindow.smooth == true)
                {
                    for (int i = 0; i <= MainWindow.MoveSteps; i++)
                    {
                        CurPosition.X += 1;
                        Cursor.Position = CurPosition;
                        Thread.Sleep(20);
                        if (MainWindow.abort == true) break;
                    }
                    for (int i = 0; i <= MainWindow.MoveSteps; i++)
                    {
                        CurPosition.Y += 1;
                        Cursor.Position = CurPosition;
                        Thread.Sleep(20);
                        if (MainWindow.abort == true) break;
                    }
                    for (int i = 0; i <= MainWindow.MoveSteps; i++)
                    {
                        CurPosition.X -= 1;
                        Cursor.Position = CurPosition;
                        Thread.Sleep(20);
                        if(MainWindow.abort == true) break;
                    }
                    for (int i = 0; i <= MainWindow.MoveSteps; i++)
                    {
                        CurPosition.Y -= 1;
                        Cursor.Position = CurPosition;
                        Thread.Sleep(20);
                        if (MainWindow.abort == true) break;
                    }
                }
                else
                {
                    CurPosition.X += MainWindow.MoveSteps;
                    Cursor.Position = CurPosition;
                    Thread.Sleep(500);
                    if (MainWindow.abort == true) break;
                    CurPosition.Y += MainWindow.MoveSteps;
                    Cursor.Position = CurPosition;
                    Thread.Sleep(500);
                    if (MainWindow.abort == true) break;
                    CurPosition.X -= MainWindow.MoveSteps;
                    Cursor.Position = CurPosition;
                    Thread.Sleep(500);
                    if (MainWindow.abort == true) break;
                    CurPosition.Y -= MainWindow.MoveSteps;
                    Cursor.Position = CurPosition;
                }
                Thread.Sleep((MainWindow.seconds - 2) * 1000);
            }
        }
    }
}
