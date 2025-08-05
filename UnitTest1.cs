namespace xUnitTestProjectLab8;
using ClassLibraryLab8;

public class UnitTest1
{
    [Fact]

    // This test checks if the AddFirst method of LinkedList works correctly
    public void AddFirst()
    {
        //create a new linked list
        var list = new LinkedList();
        // Add items to the linked list
        list.AddFirst("Joe Blow");
        list.AddFirst("Jane Doe");
        //check the head is Jane Doe
        Assert.Equal("Jane Doe", list.GetValue(0));
    }

    [Fact]

    //This checks if the AddLast method of LinkedList works correctly

    public void AddLast()
    {
        //create a new linked list
        var list = new LinkedList();
        // Add items to the linked list
        list.AddLast("John Smith");
        list.AddLast("Bob Bobberson");
        //check the last item is Bob Bobberson
        Assert.Equal("Bob Bobberson", list.GetValue(1));
    }

    [Fact]
    // This test checks if the RemoveFirst method of LinkedList works correctly

    public void RemoveFirst()
    {
        //create a new linked list
        var list = new LinkedList();
        // Add items to the linked list
        list.AddFirst("Sam Sammerson");
        list.AddFirst("Dave Daverson");
        //remove the first item
        list.RemoveFirst();
        //check the head is now Dave Daverson
        Assert.Equal("Sam Sammerson", list.GetValue(0));
    }

    [Fact]
    // This test checks if the RemoveLast method of LinkedList works correctly
    public void RemoveLast()
    {
        //create a new linked list
        var list = new LinkedList();
        // Add items to the linked list
        list.AddLast("Joe Schmoe");
        list.AddLast("Jane Doe");
        list.AddLast("John Smith");
        //remove the last item
        list.RemoveLast();
        //check the last item is now Jane Doe
        Assert.Equal("Jane Doe", list.GetValue(1));
    }

    [Fact]
    //This checks the GetValue method of LinkedList works correctly
    public void GetValue()
    {
        //create a new linked list
        var list = new LinkedList();
        // Add item to the linked list
        list.AddLast("Bob Bobberson");
        //check the value at index 1 is Bob
        Assert.Equal("Bob Bobberson", list.GetValue(0));
    }

    [Fact]
    // This test checks if the Count property of LinkedList works correctly
    public void Count()
    {
        //create a new linked list
        var list = new LinkedList();
        // Add items to the linked list
        list.AddLast("Jane Doe");
        list.AddLast("Joe Blow");
        //check the count is 2
        Assert.Equal(2, list.Count);
    }

    [Fact]
    //this tests that GetValue throws an exception when the index is out of bounds
    public void GetValueOutOfBounds()
    {
        //create a new linked list
        var list = new LinkedList();
        // Add item to the linked list
        list.AddLast("John Smith");
        //check that an exception is thrown when trying to get a value at an out of bounds index
        Assert.Throws<ArgumentOutOfRangeException>(() => list.GetValue(1));
    }

    [Fact]
    //this tests that RemoveFirst does not throw an exception when the list is empty
    public void RemoveFirstEmptyList()
    {
        //create a new linked list
        var list = new LinkedList();
        //check that no exception is thrown when trying to remove the first item from an empty list
        list.RemoveFirst();
        //check the count is still 0
        Assert.Equal(0, list.Count);
    }

    [Fact]
    //this tests that RemoveLast does not throw an exception when the list is empty
    public void RemoveLastEmptyList()
    {
        //create a new linked list
        var list = new LinkedList();
        //check that no exception is thrown when trying to remove the last item from an empty list
        list.RemoveLast();
        //check the count is still 0
        Assert.Equal(0, list.Count);
    }
}
