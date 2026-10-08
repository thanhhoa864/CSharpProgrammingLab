using MyLib;
using Xunit;

namespace MyLib.Tests;

public class LibBaiTapTests
{
    // Kiểm tra trường hợp a = 0, b = 0, c = 0.
    // Khi đó phương trình có vô số nghiệm.
    [Fact]
    public void GiaiPTBac2_A0_B0_C0_VoSoNghiem()
    {
        double x1 = 0, x2 = 0;

        int result = LibBaiTap.GiaiPTBac2(0, 0, 0, ref x1, ref x2);

        Assert.Equal(-1, result);
    }

    // Kiểm tra trường hợp a = 0, b = 0 nhưng c khác 0.
    // Khi đó phương trình vô nghiệm.
    [Fact]
    public void GiaiPTBac2_A0_B0_CKhac0_VoNghiem()
    {
        double x1 = 0, x2 = 0;

        int result = LibBaiTap.GiaiPTBac2(0, 0, 5, ref x1, ref x2);

        Assert.Equal(0, result);
    }

    // Kiểm tra trường hợp a = 0, b khác 0.
    // Khi đó phương trình trở thành phương trình bậc nhất
    // và có đúng một nghiệm.
    [Fact]
    public void GiaiPTBac2_PhuongTrinhBac1_CoMotNghiem()
    {
        double x1 = 0, x2 = 0;

        int result = LibBaiTap.GiaiPTBac2(0, 2, -4, ref x1, ref x2);

        Assert.Equal(1, result);
        Assert.Equal(2, x1);
    }

    // Kiểm tra trường hợp Delta < 0.
    // Khi đó phương trình bậc hai không có nghiệm thực.
    [Fact]
    public void GiaiPTBac2_DeltaNhoHon0_VoNghiem()
    {
        double x1 = 0, x2 = 0;

        int result = LibBaiTap.GiaiPTBac2(1, 0, 1, ref x1, ref x2);

        Assert.Equal(0, result);
    }

    // Kiểm tra trường hợp Delta = 0.
    // Khi đó phương trình có một nghiệm kép.
    [Fact]
    public void GiaiPTBac2_DeltaBang0_CoNghiemKep()
    {
        double x1 = 0, x2 = 0;

        int result = LibBaiTap.GiaiPTBac2(1, -2, 1, ref x1, ref x2);

        Assert.Equal(1, result);
        Assert.Equal(1, x1);
    }

    // Kiểm tra trường hợp Delta > 0.
    // Khi đó phương trình có hai nghiệm phân biệt.
    [Fact]
    public void GiaiPTBac2_DeltaLonHon0_CoHaiNghiem()
    {
        double x1 = 0, x2 = 0;

        int result = LibBaiTap.GiaiPTBac2(1, -3, 2, ref x1, ref x2);

        Assert.Equal(2, result);
        Assert.Equal(1, x1);
        Assert.Equal(2, x2);
    }

    // Kiểm tra trường hợp phương trình có hai nghiệm.
    // Hai nghiệm phải được sắp xếp theo thứ tự tăng dần.
    [Fact]
    public void GiaiPTBac2_HaiNghiem_LuonDuocSapXepTangDan()
    {
        double x1 = 0, x2 = 0;

        int result = LibBaiTap.GiaiPTBac2(-1, 3, -2, ref x1, ref x2);

        Assert.Equal(2, result);
        Assert.Equal(1, x1);
        Assert.Equal(2, x2);
        Assert.True(x1 <= x2);
    }
}