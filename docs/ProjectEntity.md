# IO.Swagger.Model.ProjectEntity
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ParentTitle** | **string** |  | [optional] 
**Customer** | **int?** |  | [optional] 
**Id** | **int?** |  | [optional] 
**Name** | **string** |  | 
**OrderNumber** | **string** |  | [optional] 
**OrderDate** | **DateTime?** |  | [optional] 
**Start** | **DateTime?** |  | [optional] 
**End** | **DateTime?** |  | [optional] 
**Comment** | **string** |  | [optional] 
**Visible** | **bool?** |  | 
**Budget** | **float?** |  | 
**TimeBudget** | **int?** |  | 
**MetaFields** | [**List&lt;ProjectMeta&gt;**](ProjectMeta.md) | All visible meta (custom) fields registered with this project | [optional] 
**Teams** | [**List&lt;Team&gt;**](Team.md) | If no team is assigned, everyone can access the project (also depends on the teams of the customer) | [optional] 
**Color** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

