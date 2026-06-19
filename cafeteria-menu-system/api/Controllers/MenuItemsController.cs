using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using api.Data;
using api.Models;

namespace api.Controllers;

[ApiController]
[Route("api/[controller]")] // creates the route api/menuitems
public class MenuItemsController : ControllerBase
{
    // to hold the database connection provided by ASP.NET core
    private readonly AppDbContext _context;

    // recievs AppDbcontext through dependency 
public MenuItemsController(AppDbContext context)
    {
        _context = context;
    }

    // 
    // tis is for gettin all menu items from the database
    [HttpGet]
public async Task<ActionResult<List<MenuItem>>> GetAllMenuItems()
    {
        List<MenuItem> menuItems =
            await _context.MenuItems.ToListAsync();

        return Ok(menuItems);
    }

    
    // to find one menu item by its Id 
    [HttpGet("{id}")]
    public async Task<ActionResult<MenuItem>> GetMenuItemById(int id) {
        MenuItem? foundMenuItem =
            await _context.MenuItems.FindAsync(id);

        if (foundMenuItem == null)
        {
            return NotFound();
        }

        return Ok(foundMenuItem);
    }

   
    // to add a new menu item to the database
    [HttpPost]
    public async Task<ActionResult<MenuItem>> AddMenuItem(
        MenuItem newMenuItem)
{
        _context.MenuItems.Add(newMenuItem);

        await _context.SaveChangesAsync();

        return Ok(newMenuItem);
}

    // to update a menu item in the database by its Id
    [HttpPut("{id}")]
    public async Task<ActionResult<MenuItem>> UpdateMenuItem(
        int id,
        MenuItem updatedMenuItem)
    {
        // first find the menu item by its Id
        MenuItem? existingMenuItem =
            await _context.MenuItems.FindAsync(id);

        // if the menu item does not exist return not found
        if (existingMenuItem == null)
        {
            return NotFound();
        }

        // change the old menu valus with the new values
 existingMenuItem.MenuDate = updatedMenuItem.MenuDate;
 existingMenuItem.Soup = updatedMenuItem.Soup;
existingMenuItem.MainCourse = updatedMenuItem.MainCourse;
     existingMenuItem.SideDish = updatedMenuItem.SideDish;
existingMenuItem.ExtraItem = updatedMenuItem.ExtraItem;

        // save the changes in the database
        await _context.SaveChangesAsync();

        // return the updated menu item
        return Ok(existingMenuItem);
    }

    // to delete a menu item from the database by its Id
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteMenuItem(int id)
    {
        // first find the menu item by its Id
        MenuItem? existingMenuItem =
            await _context.MenuItems.FindAsync(id);

        // if the menu item does not exist return not found
        if (existingMenuItem == null)
        {
            return NotFound();
        }

        // remove 
        _context.MenuItems.Remove(existingMenuItem);

        // save changes
        await _context.SaveChangesAsync();

        // return no content if the item was deleted
        return NoContent();
    }
}
