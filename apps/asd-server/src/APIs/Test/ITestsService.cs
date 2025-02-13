using Asd.APIs.Common;
using Asd.APIs.Dtos;

namespace Asd.APIs;

public interface ITestsService
{
    /// <summary>
    /// Create one Test
    /// </summary>
    public Task<Test> CreateTest(TestCreateInput test);

    /// <summary>
    /// Delete one Test
    /// </summary>
    public Task DeleteTest(TestWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Tests
    /// </summary>
    public Task<List<Test>> Tests(TestFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Test records
    /// </summary>
    public Task<MetadataDto> TestsMeta(TestFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Test
    /// </summary>
    public Task<Test> Test(TestWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Test
    /// </summary>
    public Task UpdateTest(TestWhereUniqueInput uniqueId, TestUpdateInput updateDto);
}
