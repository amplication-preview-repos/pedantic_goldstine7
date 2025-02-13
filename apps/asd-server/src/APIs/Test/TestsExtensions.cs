using Asd.APIs.Dtos;
using Asd.Infrastructure.Models;

namespace Asd.APIs.Extensions;

public static class TestsExtensions
{
    public static Test ToDto(this TestDbModel model)
    {
        return new Test
        {
            CreatedAt = model.CreatedAt,
            Description = model.Description,
            Id = model.Id,
            Name = model.Name,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static TestDbModel ToModel(this TestUpdateInput updateDto, TestWhereUniqueInput uniqueId)
    {
        var test = new TestDbModel
        {
            Id = uniqueId.Id,
            Description = updateDto.Description,
            Name = updateDto.Name
        };

        if (updateDto.CreatedAt != null)
        {
            test.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            test.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return test;
    }
}
