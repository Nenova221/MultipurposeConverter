using Converter;
using Xunit;


namespace MultipurposeConverterTest
{
    public class MultipurposeCoverterTest
    {
        [Theory]
        [InlineData(2401, "lbs", 171.5, "st")]
        [InlineData(171.5, "st", 2401, "lbs")]
        [InlineData(29.2, "st", 185.4, "k")]
        [InlineData(185.4, "k", 29.2, "st")]
        [InlineData(821.1, "lbs", 372.4, "k")]
        [InlineData(372.4, "k", 821.1, "lbs")]
        public void Converter_WithConvertStonsToPounds_ShouldReturnCorrect(float fromvalue, string fromunit, float tovalue, string tounit)
        {
            float result = MultipurposeConverter.Convert(fromvalue, fromunit, tounit);
            Assert.Equal(tovalue, result, 1);
        }
        [Theory]
        [InlineData(744, "km", 533, "mm")]
        [InlineData(48, "cd", 254, "sr")]
        public void Converter_WithInvalidUnit_ShouldThrowExeption(float value, string fromunit, float expectedvalue, string tounit)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => MultipurposeConverter.Convert(value, fromunit, tounit));
        }
    }
}