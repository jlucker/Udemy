<template>
    <div class="container">
        <div class="row">
            <div class="col-xs-12 col-sm-8 col-sm-offset-2 col-md-6 col-md-offset-3">
                <h1>Filters & Mixins</h1>

                <h3>Exercise 1</h3>
                <p>Build a local Filter which reverses the Text it is applied on.</p>
                <p>{{ 'Some Text' | reverse }}</p>
                <hr>

                <h3>Exercise 2</h3>
                <p>Build a global Filter which counts the length of a word and it appends it.</p>
                <p>{{ 'Justin' | calculateLength }}</p>
                <hr>

                <h3>Exercise 3</h3>
                <p>Do the same as in Exercises 1 & 2, now with Computed Properties</p>
                <p>{{ reversed }}</p>
                <p>{{ lengthAware }}</p>
                <hr>

                <h3>Exercise 4</h3>
                <p>Share the Computed Property rebuilding Exercise 2 via a Mixin</p>
                <p>{{ lengthAware }}</p>

            </div>
        </div>
    </div>
</template>

<script>
    import { lengthAwareMixin } from './lengthAwareMixin';

    export default {
        mixins: [lengthAwareMixin],
        data() {
            return{
                firstText: 'Some Text',
                secondText: 'Justin'
            }
        },
        filters: {
            reverse(value) {
                return value.split("").reverse().join("");
            }
        },
        computed: {
            reversed() {
                return this.firstText.split("").reverse().join("");
            },
            lengthAware() {
                return this.secondText + ' (' + this.secondText.length  + ')';
            }
        }
    }
</script>

<style>
</style>
