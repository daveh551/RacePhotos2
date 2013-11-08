This project is a do-over of the (now discontinued) RacePhotos.

The do-over was prompted by the release of Visual Studio 2013 and MVC5.

While it would have been possible to retro-fit the old site with the MVC5 features,
not enough progress had been made on it to make it worth the effort.

The new version will also make use of the Highway.Data framework encapsulating the 
EntityData interaction into a Repository.

This project will be the Web and User-Interaction portion of a project to serve up photos
taken during running races, and possibly other competitive events.   It will allow users
to search and view a collection of photos by race event, and by event time, as well as 
possibly other tags, as well  as to order downloads or finished prints of photographs.

A companion back-end server project, PhotoServer2, will implement a RESTful WebAPI service
responsible for storing the photo collections, organizing and indexing them by time  and
designated tags, serving them in various resolutions, and applying watermarks for copy right 
protection.

