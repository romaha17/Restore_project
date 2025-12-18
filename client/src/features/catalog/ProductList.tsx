import { Grid2 } from "@mui/material"
import type { Product } from "../../app/models/Product"
import ProductCard from "./ProductCard"

type Props = {
    products: Product[]
}

export default function ProductList({products} : Props) {
  return (
    <Grid2 container spacing={4}>
        {products.map(product => (
          <Grid2 key={product.id} size={3}>
            <ProductCard product={product}></ProductCard>
          </Grid2>
        ))}
    </Grid2>
  )
}