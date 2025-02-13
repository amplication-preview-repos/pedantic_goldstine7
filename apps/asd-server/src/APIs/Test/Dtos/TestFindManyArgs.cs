using Asd.APIs.Common;
using Asd.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asd.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class TestFindManyArgs : FindManyInput<Test, TestWhereInput> { }
