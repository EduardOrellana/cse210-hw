//Parent Class

public abstract class Activity
{
    //Attributes

    protected string _date;
    protected float _length;
    protected double _distance;
    protected double _speed;
    protected int _laps;
    protected double _pace;

    //Constructors
    public Activity(string date, float len)
    {
        _date = date;
        _length = len;
    }
    
    public Activity(string date, float len, int laps)
    {
        _date = date;
        _length = len;
        _laps = laps;
    }

    public Activity(string date, float len, double distance)
    {
        _date = date;
        _length = len;
        _distance = distance;
    }

    //General Methods

    public virtual string GetSummary()
    {    
        return $"{_date} Activity: ({_length} min)-Distance {_distance:2F} km, Speed: {_speed} kph, Pace: {_pace} min per km";
    }
    public virtual double CalDistance()
    {
        // _distance = _laps * 50 * 1000;  
        return _distance;
    }

    public abstract double CalSpeed();

    public abstract double CalPace();
}