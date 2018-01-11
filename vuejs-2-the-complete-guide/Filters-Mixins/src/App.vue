<template>
    <div class="container">
        <div class="row">
            <div class="col-xs-12 col-sm-8 col-sm-offset-2 col-md-6 col-md-offset-3">
                <h1>Filters & Mixins</h1>
                <p>{{ text | toUppercase | to-lowercase }}</p>
                <hr>

                <h2>Filter</h2>
                <ul>
                    <li v-for="fruit in fruits"> {{ fruit }}</li>
                </ul>
                <hr>
                <h2>Computed Property</h2>
                <button @click="fruits.push('Berries')">Add New Item</button>
                <input v-model="filterText">
                <ul>
                    <li v-for="fruit in filteredFruits"> {{ fruit }}</li>
                </ul>
                <hr>

            </div>
        </div>
        <div class="row">
            <app-list></app-list>
        </div>
    </div>
</template>

<script>
    import List from './List.vue';
    import { fruitMixin } from './fruitMixin';

    export default {
        mixins: [fruitMixin],
        data() {
            return {
                text: 'Hello there!'
            }
        },
        filters: {
            toUppercase(value){
                return value.toUpperCase();
            }
        },
        components: {
            appList: List
        }
    }
</script>

<style>

</style>
