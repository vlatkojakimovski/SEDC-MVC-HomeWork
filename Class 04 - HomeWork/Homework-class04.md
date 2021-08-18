# Homework - Class 04

Use the SEDC.PizzaApp project from Class 04

1. Use the property IsOnPromotion from Pizza Model and add it to the PizzaViewModel. 
Use an if expression in the Pizza Details View and add a h4 tag that will stay whether 
the pizza is on promotion or not depending on the property IsOnPromotion.

2. Send a list of pizza view models to the Pizaa Index View. 
Loop through them using a for loop in the view.

##Bonus
Add partial view for Pizza Details and use it in both the Pizza Index and Pizza Details view.


    @{ if (ViewBag.Pizza.IsOnPromotion)
        {
            <h4> "On PROMOTION!!" </h4>
        }
        else
        {
            <h4> "NO promotion!!" </h4>
            }
        }


## Contact
Trainer: panovski.martin93@gmail.com

Co-Trainer: fjanev14@gmail.com