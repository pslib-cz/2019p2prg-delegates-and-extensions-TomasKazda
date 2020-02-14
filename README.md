# Test Delegáty a Extension metody
Testové zadání na delegáty a extension metody v CSharpu.

Samostatně vytvořte kód rozšiřující vhodnou kolekci a následující extension metody. Máte k dispozici referenční zdroje na internetu a případné konzultace s vyučujícím. Z technických prostředků je možné veškeré metody naprogramovat kompletně algoritmicky nebo využít již známých metod LINQ.

Vytvořte minimálně jednu z následujících extension metod, v programu předveďte jejich funkčnost. Metody nejsou závislé na konkrétním datovém typu, měly by tedy být definovány jako generické extension metody nad generickou kolekcí s typem "T".

## RandomElement
Metoda vrací z dané kolekce vždy *jeden* náhodný prvek.

Nápovědy: 
* Jak se používá generátor náhodných čísel?
* Co když kolekce neobsahuje žádné prvky?

Bodování: 3

## RandomElementsWith
Metoda vrací *daný počet různých náhodných* prvků splňujících *podmínku danou delegátem*. 

Nápovědy:
* Jak se správně používá generátor náhodných čísel?
* Co když kolekce nemá dost prvků?
* Jak udělat, aby se prvky neopakovaly?
* Známe nějaký prostředek, kterým lze omezit kolekci prvků podle podmínky v nějakém delegátu?
* Existuje nějaký systémový delegát, který by se zde dal využít?
* Jak vrátit najednou několik prvků?

Bodování: 6

## AppearanceGreaterThen
Metoda vrací kolekci všech prvků (každý jen jednou), které se v kolekci vyskytují *ve větším (nebo stejném - tj ">=" ) počtu*, než je metodě předáno parametrem.

Nápovědy:
* Co když se v kolekci nenachází žádné prvky?
* Co když se žádný prvek v kolekci nevyskytuje vícekrát, než je počet daný parametrem metody?
* Známe nějaký elegantní nástroj, jak lze vytvořit skupiny prvků?
* Jak vracet kolekci a jakou?

Bodování: 6
