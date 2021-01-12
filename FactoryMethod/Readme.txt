Factory Method: when and where you would use it

Class constructors exist so that clients can create instances of a class. However, there are situations, where the client does not, or should not, know which one
of several candidate classes to instantiate. The Factory Method allows the client to use an interface for creating an object while still retaining control over which
class to instantiate.

The key objective of the Factory Method is extensibility. Factory Methods are frequently used in applications that manage, maintain, or manipulate collections
of objects that are different but at the same time have many characteristics in common.

A document management system, for example, is more extensible by referencing the documents as a collection of IDocuments. These documents may be Text files,
Word documents, Visio diagrams, or legal papers. They are different but each one has an author, a title, a type, a size, a location, a page count, etc.
When a new document type is introduced it simply implements the IDocument interface and it will work like the rest of the documents. To support this new
document type the Factory Method may or may not have to be adjusted (depending on how it was implemented, i.e. with or without parameters).


Participants
The classes and/or objects participating in this pattern are:

 Product (Page)
	o defines the interface of objects the factory method creates
 ConcreteProduct (SkillsPage, EducationPage, ExperiencePage)
	o implements the Product interface
 Creator (Document)
	o declares the factory method, which returns an object of type Product. Creator may also define a default implementation of the factory method that returns a default ConcreteProduct object.
	o may call the factory method to create a Product object.
 ConcreteCreator (Report, Resume)
	o overrides the factory method to return an instance of a ConcreteProduct.