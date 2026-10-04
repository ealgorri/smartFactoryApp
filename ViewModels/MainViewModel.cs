using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Drawing;
using smartFactoryApp.Models;
using static smartFactoryApp.Models.Parameters;

namespace smartFactoryApp.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    Robot robot;
    Rectangle borders;
    public double RobotX => robot.Location.X;
    public double RobotY => robot.Location.Y;
    public double RobotAngle => robot.Angle;
    public MainViewModel()
    {
        robot = new Robot(new Point(300, 300), new Rectangle(37, 35, 452, 480));
    }   
    public void MoveLeft()
    {
        robot.Bewegen(Direction.left);
        NotifyRobotPositionChanged();
    }
    public void MoveRight()
    {
        robot.Bewegen(Direction.right);
        NotifyRobotPositionChanged();
    }
    public void MoveUp()
    {
        robot.Bewegen(Direction.up);
        NotifyRobotPositionChanged();
    }
    public void MoveDown()
    {
        robot.Bewegen(Direction.down);
        NotifyRobotPositionChanged();
    }
    public void MoveUpRight()
    {
        robot.Bewegen(Direction.upRight);
        NotifyRobotPositionChanged();
    }
    public void MoveUpLeft()
    {
        robot.Bewegen(Direction.upLeft);
        NotifyRobotPositionChanged();
    }
    public void MoveDownRight()
    {
        robot.Bewegen(Direction.downRight);
        NotifyRobotPositionChanged();
    }
    public void MoveDownLeft()
    {
        robot.Bewegen(Direction.downLeft);
        NotifyRobotPositionChanged();
    }
    public void MoveRotateRight()
    {
        robot.Bewegen(Direction.rotateRight);
        NotifyRobotPositionChanged();
    }
    public void MoveRotateLeft()
    {
        robot.Bewegen(Direction.rotateLeft);
        NotifyRobotPositionChanged();
    }
    public void Stop()
    {
        robot.Bewegen(Direction.stop);
        NotifyRobotPositionChanged();
    }
    private void NotifyRobotPositionChanged()
    {
        OnPropertyChanged(nameof(RobotX));
        OnPropertyChanged(nameof(RobotY));
        OnPropertyChanged(nameof(RobotAngle));
    }
}
