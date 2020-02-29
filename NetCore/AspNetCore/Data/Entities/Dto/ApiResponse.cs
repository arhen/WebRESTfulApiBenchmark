namespace AspNetCore.Data.Entities.Dto
{
	public class ApiResponse{
		public bool IsError {get; set;}
		public int StatusCode {get; set;}
		public string Message {get; set;}
		public object Results {get; set;}

		public ApiResponse(bool isError = false, int statusCode = 200, object results = null, string message = "Request Successful."){
			IsError = isError;
			StatusCode = statusCode;
			Results = results;
			Message = message;
		}
	}
}
