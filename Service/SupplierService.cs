using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

public class SupplierService : ISupplierService
{

    private readonly ISupplierRepository _supplierRepository;

    public SupplierService(ISupplierRepository supplierRepository)
    {
        _supplierRepository = supplierRepository;
    }

    public async Task<SupplierDTO> GetSupplierByEmail(string email)
    {
        SupplierDTO supplierDTO = await _supplierRepository.GetSupplierByEmail(email);
        if (supplierDTO != null)
        {
            return supplierDTO;
        }
        return new SupplierDTO(null);
    }

    public async Task<IEnumerable<SupplierDTO>> GetSupplierByMinRatingAndAbove(string MinRating)
    {
        double minrating = 0;
        var min = double.TryParse(MinRating, out minrating);
        if(!min)
        {
            throw new NotImplementedException();
        }
        return await _supplierRepository.GetSupplierByMinRatingAndAbove(minrating);
    }

    public async Task<IEnumerable<SupplierDTO>> GetSupplierByRating(string Rating)
    {
        double _rating = 0;
        var min = double.TryParse(Rating, out _rating);
        if(!min)
        {
            throw new NotImplementedException();
        }
        return await _supplierRepository.GetSupplierByRating(_rating);
    }

    public async Task<IEnumerable<SupplierDTO>> GetSupplierByRatingRange(string DownRating, string UpRating)
    {
        double down_rating = 0, up_rating = 0;
        var down = double.TryParse(DownRating, out down_rating);
        var up = double.TryParse(UpRating, out up_rating);
        if(!down || !up)
        {
            throw new NotImplementedException();
        }
        return await _supplierRepository.GetSupplierByRatingRange(down_rating,up_rating);
    }

    async Task<SupplierDTO> ISupplierService.CreateSupplierOperation(SupplierDTO supplier)
    {
        SupplierDTO supplierDTO = await _supplierRepository.GetSupplierByName(supplier.Name);
        if (supplierDTO == null)
        {
            return await _supplierRepository.CreateSupplierOperation(supplier);
        }
        return new SupplierDTO(null);
    }

    async Task<SupplierDTO> ISupplierService.DeleteSupplierOperation(int id)
    {
        SupplierDTO supplierDTO = await _supplierRepository.GetSupplierById(id);
        if (supplierDTO != null)
        {
            return await _supplierRepository.ChangeSupplierVisibility(id);
        }
        return new SupplierDTO(null);
    }

    async Task<IEnumerable<SupplierDTO>> ISupplierService.GetAllSupplier()
    {
        IEnumerable<SupplierDTO> supplierDTOs = await _supplierRepository.GetAllSupplier();
        if (supplierDTOs != null)
        {
            return supplierDTOs;
        }
        return new List<SupplierDTO> { new SupplierDTO(null) };
    }

    async Task<SupplierDTO> ISupplierService.GetSupplierById(int id)
    {
        SupplierDTO supplierDTO = await _supplierRepository.GetSupplierById(id);
        if (supplierDTO != null)
        {
            return supplierDTO;
        }
        return new SupplierDTO(null);
    }

    async Task<SupplierDTO> ISupplierService.GetSupplierByName(string name)
    {
        SupplierDTO supplierDTO = await _supplierRepository.GetSupplierByName(name);
        if (supplierDTO != null)
        {
            return supplierDTO;
        }
        return new SupplierDTO(null);
    }

    async Task<SupplierDTO> ISupplierService.UpdateSupplierOperation(int id, SupplierDTO supplier)
    {
        SupplierDTO supplierDTO = await _supplierRepository.GetSupplierById(id);
        if (supplierDTO != null)
        {
            return await _supplierRepository.UpdateSupplierOperation(id, supplier);
        }
        return new SupplierDTO(null);
    }
}