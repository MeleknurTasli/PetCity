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
        SupplierDTO supplierDTO = new SupplierDTO(await _supplierRepository.GetSupplierByEmail(email));
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
        return SupplierToSupplierDTO(await _supplierRepository.GetSupplierByMinRatingAndAbove(minrating));
    }

    public async Task<IEnumerable<SupplierDTO>> GetSupplierByRating(string Rating)
    {
        double _rating = 0;
        var min = double.TryParse(Rating, out _rating);
        if(!min)
        {
            throw new NotImplementedException();
        }
        return SupplierToSupplierDTO(await _supplierRepository.GetSupplierByRating(_rating));
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

        return SupplierToSupplierDTO(await _supplierRepository.GetSupplierByRatingRange(down_rating,up_rating));
    }

    public IEnumerable<SupplierDTO> SupplierToSupplierDTO(IEnumerable<Supplier> suppliers)
    {//TODO degisecek
        List<SupplierDTO> supplierDTOs = new List<SupplierDTO>();
        foreach(Supplier item in suppliers)
        {
            supplierDTOs.Add(new SupplierDTO(item));
        }
        return supplierDTOs;
    }

    async Task<SupplierDTO> ISupplierService.CreateSupplierOperation(Supplier supplier)
    {
        Supplier supplierResponse = await _supplierRepository.GetSupplierByName(supplier.Name);
        if (supplierResponse == null)
        {
            return new SupplierDTO(await _supplierRepository.CreateSupplierOperation(supplier));
        }
        return new SupplierDTO(null);
    }

    async Task<SupplierDTO> ISupplierService.DeleteSupplierOperation(int id)
    {
        SupplierDTO supplierDTO = new SupplierDTO(await _supplierRepository.GetSupplierById(id));
        if (supplierDTO != null)
        {
            return new SupplierDTO(await _supplierRepository.ChangeSupplierVisibility(id));
        }
        return new SupplierDTO(null);
    }

    async Task<IEnumerable<SupplierDTO>> ISupplierService.GetAllSupplier()
    {         
        IEnumerable<SupplierDTO> supplierDTOs = SupplierToSupplierDTO(await _supplierRepository.GetAllSupplier());
        if (supplierDTOs != null)
        {
            return supplierDTOs;
        }
        return new List<SupplierDTO> { new SupplierDTO(null) };
    }

    async Task<SupplierDTO> ISupplierService.GetSupplierById(int id)
    {
        SupplierDTO supplierDTO = new SupplierDTO(await _supplierRepository.GetSupplierById(id));
        if (supplierDTO != null)
        {
            return supplierDTO;
        }
        return new SupplierDTO(null);
    }

    async Task<SupplierDTO> ISupplierService.GetSupplierByName(string name)
    {
        SupplierDTO supplierDTO = new SupplierDTO(await _supplierRepository.GetSupplierByName(name));
        if (supplierDTO != null)
        {
            return supplierDTO;
        }
        return new SupplierDTO(null);
    }

    async Task<SupplierDTO> ISupplierService.UpdateSupplierOperation(int id, Supplier supplier)
    {
        SupplierDTO supplierDTO = new SupplierDTO(await _supplierRepository.GetSupplierById(id));
        if (supplierDTO != null)
        {
            return new SupplierDTO(await _supplierRepository.UpdateSupplierOperation(id, supplier));
        }
        return new SupplierDTO(null);
    }

    
}