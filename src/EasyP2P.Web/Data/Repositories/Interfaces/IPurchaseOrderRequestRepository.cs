﻿using EasyP2P.Web.Enums;
using EasyP2P.Web.Models;
using EasyP2P.Web.Models.Database;

namespace EasyP2P.Web.Data.Repositories.Interfaces;

public interface IPurchaseOrderRequestRepository
{
    Task<IEnumerable<PurchaseOrderRequestDatabaseModel>> GetAllAsync();
    Task<PurchaseOrderRequestDatabaseModel?> GetByIdAsync(int id);
    Task<int> CreateAsync(PurchaseOrderRequestInputModel model, string requestedBy);
    Task<bool> DeleteAsync(int id);
    Task<IEnumerable<PurchaseOrderRequestDatabaseModel>> GetByStatusAsync(PurchaseOrderRequestState status);
    Task<bool> UpdateStatusAsync(int id, PurchaseOrderRequestState status, string updatedBy);
    Task<bool> CanTransitionToStatus(int id, PurchaseOrderRequestState newStatus);
}