namespace Phosphor.UnitTests;

public class IconNameTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test_with_thumbs_up_thin()
    {
        var iconName = new IconName("thumbs-up-thin");
        
        Assert.Multiple(() =>
        {
            Assert.That(iconName.PropertyName, Is.EqualTo("ThumbsUp"));
            Assert.That(iconName.CssClasses, Is.EqualTo("ph-thin ph-thumbs-up"));
        });
    }
    
    [Test]
    public void Test_with_thumbs_up()
    {
        var iconName = new IconName("thumbs-up");
        
        Assert.Multiple(() =>
        {
            Assert.That(iconName.PropertyName, Is.EqualTo("ThumbsUp"));
            Assert.That(iconName.CssClasses, Is.EqualTo("ph ph-thumbs-up"));
        });
    }
    
    [Test]
    public void Test_with_thumbs_up_bold()
    {
        var iconName = new IconName("thumbs-up-bold");
        
        Assert.Multiple(() =>
        {
            Assert.That(iconName.PropertyName, Is.EqualTo("ThumbsUp"));
            Assert.That(iconName.CssClasses, Is.EqualTo("ph-bold ph-thumbs-up"));
        });
    }
    
    [Test]
    public void Test_with_thumbs_up_duotone()
    {
        var iconName = new IconName("thumbs-up-duotone");
        
        Assert.Multiple(() =>
        {
            Assert.That(iconName.PropertyName, Is.EqualTo("ThumbsUp"));
            Assert.That(iconName.CssClasses, Is.EqualTo("ph-duotone ph-thumbs-up"));
        });
    }
}