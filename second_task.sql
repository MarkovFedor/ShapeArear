select pr.Name, cat.Name from Product as pr
                                  left join Product_to_Category as PtC
                                            on pr.id = PtC.product_id
                                  left join Category as cat
                                            on cat.id = PtC.category_id
