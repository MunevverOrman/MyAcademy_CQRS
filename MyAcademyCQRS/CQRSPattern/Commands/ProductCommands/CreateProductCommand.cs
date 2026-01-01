namespace MyAcademyCQRS.CQRSPattern.Commands.ProductCommands;

public record CreateProductCommand(string Name,
                                   string Description,
                                   string Price,
                                   string ImageUrl,
                                   int CategoryId);

