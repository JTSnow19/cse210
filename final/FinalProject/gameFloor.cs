public class GameFloor{

    int _room;
    int _floor;
    int _roomCap;

    public void ResetRoom(){
        _room = 0;
    }
    public void IncreaseFloor(){
        _floor ++;
    }
    public void IncreaseRoom(){
        _room ++;
    }
    public void roomStatus(){
        if (_room == _roomCap){
            ResetRoom();
            IncreaseFloor();
        }
    }
    public void ClimbProgress(){
        Console.WriteLine($"Floor: {_floor}||| Room: {_room}/{_roomCap}");
    }
}