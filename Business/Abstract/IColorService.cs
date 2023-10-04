using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Dtos;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();

        IDataResult<List<ColorDetailDto>> GetColorDetails();

        IDataResult<Color> GetById(int id);

        IResult Add(Color color);

        IResult Update(Color color);

        IResult Delete(Color color);
    }
}
