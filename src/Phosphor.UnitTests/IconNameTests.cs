namespace Phosphor.UnitTests;

public class IconNameTests
{
    [Fact]
    public void Test_with_thumbs_up_thin()
    {
        var iconName = new IconName("thumbs-up-thin");

        Assert.Equal("ThumbsUp", iconName.PropertyName);
        Assert.Equal("ph-thin ph-thumbs-up", iconName.CssClasses);
    }

    [Fact]
    public void Test_with_thumbs_up()
    {
        var iconName = new IconName("thumbs-up");

        Assert.Equal("ThumbsUp", iconName.PropertyName);
        Assert.Equal("ph ph-thumbs-up", iconName.CssClasses);
    }

    [Fact]
    public void Test_with_thumbs_up_bold()
    {
        var iconName = new IconName("thumbs-up-bold");

        Assert.Equal("ThumbsUp", iconName.PropertyName);
        Assert.Equal("ph-bold ph-thumbs-up", iconName.CssClasses);
    }

    [Fact]
    public void Test_with_thumbs_up_duotone()
    {
        var iconName = new IconName("thumbs-up-duotone");

        Assert.Equal("ThumbsUp", iconName.PropertyName);
        Assert.Equal("ph-duotone ph-thumbs-up", iconName.CssClasses);
    }
}
