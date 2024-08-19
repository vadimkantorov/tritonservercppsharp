# Example of generating C# bindings to the C-API interface of [Triton Inference Server](https://github.com/triton-inference-server/server) using the [CppSharp](https://github.com/mono/CppSharp) tool

See the complete script at [tritonservercppsharp.yml](./.github/workflows/tritonservercppsharp.yml)

# References
- https://github.com/triton-inference-server/server/blob/main/docs/customization_guide/inference_protocols.md#java-bindings-for-in-process-triton-server-api
- https://github.com/triton-inference-server/server/issues/7543
- https://github.com/triton-inference-server/core/blob/main/include/triton/core/tritonserver.h
- https://github.com/triton-inference-server/developer_tools/blob/main/server/include/triton/developer_tools/server_wrapper.h
- https://github.com/bytedeco/javacpp-presets/blob/master/tritonserver/src/gen/java/org/bytedeco/tritonserver/global/tritonserver.java
