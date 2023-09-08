class Textbox {
    constructor(selector, regex) {
        this._value;
        this._elements = document.querySelectorAll(selector);
        this._invalidSymbols = regex;
    }

    set value(value) {
        this._value = value;
        let elements = Array.from(this._elements);
        elements.forEach(element => element.value = value);
    }

    get value() {
      return this._value;
    }

    get elements() {
      return this._elements;
    }

    isValid() {
        let elements = Array.from(this._elements);
        for (let element of elements) {
            if (element.value.match(this._invalidSymbols)) {
                return false;
            }
        }
        return true;
    }
}

let textbox = new Textbox(".textbox",/[^a-zA-Z0-9]/);
let inputs = document.getElementsByClassName('.textbox');

inputs.addEventListener('click',function(){console.log(textbox.value);});
