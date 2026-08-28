using NUnit.Framework;

[TestFixture]
public class AutocompleteTests
{
    Autocomplete a;

    [SetUp]
    public void Setup()
    {
        a = new Autocomplete();
    }

    [Test]
    public void AddWordTest()
    {
        a.AddWord("apple", 50);
        Assert.That(a.Find("apple"), Is.True);
    }

    [Test]
    public void FindMissingWordTest()
    {
        a.AddWord("apple", 50);
        Assert.That(a.Find("banana"), Is.False);
    }

    [Test]
    public void UndoTest()
    {
        a.UndoAdd("apple");
        Assert.That(a.Undo(), Is.EqualTo("apple"));
    }

    [Test]
    public void UndoEmptyTest()
    {
        Assert.That(a.Undo(), Is.Null);
    }

    [Test]
    public void UpdateTest(){
        a.AddUpdate("orange");
        a.ProcessUpdates();
        Assert.That(a.Find("orange"), Is.True);
    }
}
